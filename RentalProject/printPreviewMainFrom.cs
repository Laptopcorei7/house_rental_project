using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace RentalProject
{
    public partial class printPreviewMainFrom : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public printPreviewMainFrom(string bookID, string fullName, string email, string contact, string gender,
                                string houseID, string rent, string initial, DateTime startOfRent, DateTime endOfRent, string totalPrice)
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            print_bookID.Text = bookID;
            print_fullName.Text = fullName;
            print_email.Text = email;
            print_contact.Text = contact;
            print_gender.Text = gender;
            print_houseID.Text = houseID;
            print_rent.Text = rent;
            print_initial.Text = initial;
            print_startOfRent.Text = startOfRent.ToShortDateString();
            print_endOfRent.Text = endOfRent.ToShortDateString();
            print_totalPrice.Text = totalPrice;


        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreview = new PrintPreviewDialog
            {
                Document = printDocument,
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.CenterScreen
            };
            print_btn.Visible = false;
            print_close.Visible = false;


            try
            {
                // Show the print preview dialog
                printPreview.ShowDialog();
            }
            finally
            {
                // Restore the print button visibility after the preview is closed
                print_btn.Visible = true;
                print_close.Visible = true;
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up the page settings to match A4 size at 96 DPI
            e.PageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            e.PageSettings.Margins = new Margins(0, 0, 0, 0);

            // Create a bitmap of the form
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Calculate scaling to fit the A4 page width
            float scaleX = e.PageBounds.Width / (float)this.Width;
            float scaleY = (e.PageBounds.Height / 2) / (float)this.Height; // Only use half the height for one form
            float scale = Math.Min(scaleX, scaleY);

            int printWidth = (int)(this.Width * scale);
            int printHeight = (int)(this.Height * scale);

            // Draw the form content twice to fill the A4 sheet
            e.Graphics.DrawImage(bitmap, 0, 0, printWidth, printHeight);
            e.Graphics.DrawImage(bitmap, 0, printHeight, printWidth, printHeight);
        }

        private void print_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
