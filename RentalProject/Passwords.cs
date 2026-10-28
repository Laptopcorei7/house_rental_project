using System.Data.SqlClient;
using System.Security.Cryptography;

namespace RentalProject
{
    // Passwords are stored as "PBKDF2$<iterations>$<salt>$<hash>" with salt and hash in Base64, never as plain text.
    internal static class Passwords
    {
        private const int Iterations = 100_000;

        public static string Hash(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
            return $"PBKDF2${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        public static bool Verify(string password, string stored)
        {
            string[] parts = stored.Split('$');
            if (parts.Length != 4 || parts[0] != "PBKDF2") return false;

            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expected = Convert.FromBase64String(parts[3]);
            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, int.Parse(parts[1]), HashAlgorithmName.SHA256, expected.Length);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }

        // Accounts made before hashing (and the admin seeded by SQLQuery1.sql) hold plain text.
        // This hashes them in place; it finds nothing to do once they are all converted.
        public static void HashPlainTextPasswords(SqlConnection connect)
        {
            List<(int Id, string Password)> plain = new();
            using (SqlCommand cmd = new SqlCommand("SELECT id, password FROM users WHERE password NOT LIKE 'PBKDF2$%'", connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) plain.Add((reader.GetInt32(0), reader.GetString(1)));
            }

            foreach ((int id, string password) in plain)
            {
                using SqlCommand update = new SqlCommand("UPDATE users SET password = @pass WHERE id = @id", connect);
                update.Parameters.AddWithValue("@pass", Hash(password));
                update.Parameters.AddWithValue("@id", id);
                update.ExecuteNonQuery();
            }
        }
    }

    // Who is logged in. Set by LoginFile, read by screens that must not act on the current user.
    internal static class Session
    {
        public static int UserId { get; set; }
    }
}
