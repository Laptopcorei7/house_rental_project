using System.Data.SqlClient;
using System.Diagnostics;

namespace RentalProject
{
    internal static class Program
    {
        private static readonly string LogPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RentalProject", "error.log");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Any error a button handler does not catch lands here instead of crashing the app.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => ReportError(e.Exception);

            Application.Run(new LoginFile());
        }

        private static void ReportError(Exception ex)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(LogPath)!);
                File.AppendAllText(LogPath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex}{Environment.NewLine}{Environment.NewLine}");
            }
            catch (Exception logError) when (logError is IOException or UnauthorizedAccessException)
            {
                Debug.WriteLine($"Could not write {LogPath}: {logError}");
            }

            string message = ex is SqlException
                ? "Can't reach the database. Check that SQL Server LocalDB is installed and running, then try again."
                : $"Something went wrong: {ex.Message}";

            MessageBox.Show($"{message}\n\nDetails were saved to {LogPath}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
