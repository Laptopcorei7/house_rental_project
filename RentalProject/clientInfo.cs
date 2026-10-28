using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RentalProject
{
    public partial class clientInfo : Form
    {
        private readonly Booking booking;

        internal clientInfo(Booking booking)
        {
            InitializeComponent();
            this.booking = booking;

            // The real Book ID comes from the database row, so it only exists once the booking is saved.
            clientInfo_bookID.Text = "Assigned when booked";
            client_print.Enabled = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Accepts local (0241234567) and international (+233 24 123 4567) numbers.
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string digits = Regex.Replace(phoneNumber, @"[\s-]", "");
            return Regex.IsMatch(digits, @"^\+?\d{7,15}$");
        }

        private void clientInfo_bookBtn_Click(object sender, EventArgs e)
        {
            if (clientInfo_name.Text.Trim() == "" || clientInfo_gender.SelectedIndex == -1 ||
                clientInfo_email.Text.Trim() == "" || clientInfo_contactNum.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(clientInfo_email.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhoneNumber(clientInfo_contactNum.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid phone number, for example 0241234567 or +233241234567.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Book {booking.HouseId} from {booking.Start:d} to {booking.End:d} " +
                $"on the {booking.Plan.ToLower()} plan ({booking.RateText}) for {booking.Total:0.00}?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            // Insert only if no other booking took these dates in the meantime,
            // then build the Book ID from the new row's identity.
            string insertData =
                "INSERT INTO customers (book_id, full_name, email, contact, gender, house_id, rent_amount, rent_plan, " +
                "status_payment, status, date_start, date_end, date_book) " +
                "SELECT '', @fullname, @email, @contact, @gender, @houseID, @rent, @plan, 'Paid', 'Rent Approved', " +
                "@dateStart, @dateEnd, @dateBook " +
                "WHERE NOT EXISTS (" + Booking.OverlapSql + "); " +
                "IF @@ROWCOUNT = 1 BEGIN " +
                "DECLARE @id INT = SCOPE_IDENTITY(); " +
                "UPDATE customers SET book_id = CONCAT('BID-', @id) WHERE id = @id; " +
                "SELECT CONCAT('BID-', @id); END";

            string? bookId;
            using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
            {
                connect.Open();

                using SqlCommand cmd = new SqlCommand(insertData, connect);
                cmd.Parameters.AddWithValue("@fullname", clientInfo_name.Text.Trim());
                cmd.Parameters.AddWithValue("@email", clientInfo_email.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", clientInfo_contactNum.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", clientInfo_gender.SelectedItem!.ToString());
                cmd.Parameters.AddWithValue("@rent", booking.Total);
                cmd.Parameters.AddWithValue("@plan", booking.Plan);
                cmd.Parameters.AddWithValue("@dateBook", DateTime.Today);
                booking.AddDateParameters(cmd);

                bookId = cmd.ExecuteScalar() as string;
            }

            if (bookId == null)
            {
                MessageBox.Show("Someone else just booked this house for some of those dates.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lock the form so the printed receipt matches what was saved.
            clientInfo_bookID.Text = bookId;
            clientInfo_name.Enabled = false;
            clientInfo_email.Enabled = false;
            clientInfo_contactNum.Enabled = false;
            clientInfo_gender.Enabled = false;
            clientInfo_bookBtn.Enabled = false;
            clientInfo_clearBtn.Enabled = false;
            client_print.Enabled = true;

            MessageBox.Show($"Booked successfully. Book ID: {bookId}. You can print the receipt now.",
                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clientInfo_clearBtn_Click(object sender, EventArgs e)
        {
            clientInfo_name.Text = "";
            clientInfo_email.Text = "";
            clientInfo_contactNum.Text = "";
            clientInfo_gender.SelectedIndex = -1;
        }

        private void client_print_Click(object sender, EventArgs e)
        {
            using printPreviewMainFrom printForm = new printPreviewMainFrom(
                clientInfo_bookID.Text, clientInfo_name.Text.Trim(), clientInfo_email.Text.Trim(),
                clientInfo_contactNum.Text.Trim(), clientInfo_gender.SelectedItem!.ToString()!,
                booking.HouseId, booking.RateText, booking.Deposit.ToString("0.00"),
                booking.Start, booking.End, booking.Total.ToString("0.00"));
            printForm.ShowDialog(this);
        }
    }
}
