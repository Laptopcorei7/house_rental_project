using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace RentalProject
{
    public partial class clientInfo : Form
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabeng\\Documents\\HOUSE.mdf;Integrated Security=True;Connect Timeout=30";
        private PrintDocument printDocument = new PrintDocument();

        public clientInfo()
        {
            InitializeComponent();
            displayBookID();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectBID = "SELECT COUNT(id) FROM customers";

                int getBookID = 0;

                using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (getBookID == 0)
                    {
                        getBookID += 1;
                    }
                    else
                    {
                        getBookID += 1;
                    }
                }
                clientInfo_bookID.Text = $"BID-{getBookID}";
            }
        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression to match international phone numbers
            string phonePattern = @"^\+\d{1,3}\d{1,14}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
        private void clientInfo_bookBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to book now?", "Information Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientInfo_name.Text == "" || clientInfo_gender.SelectedIndex == -1 ||
                clientInfo_email.Text == "" || clientInfo_contactNum.Text == "" || houseData1.houseID == "")
                {
                    MessageBox.Show("Please fiil all blank spaces.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!IsValidEmail(clientInfo_email.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!IsValidPhoneNumber(clientInfo_contactNum.Text))
                {
                    MessageBox.Show("Please enter a valid phone number in international format.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customers" +
                            "(book_id, full_name, email, contact, gender, house_id, rent_amount, status_payment, status, " +
                            "date_start, date_end, date_book)" +
                            "VALUES(@bookID, @fullname, @email, @contact, @gender, @houseID, @rent, @statusP" +
                            ", @status, @dateStart, @dateEnd, @dateBook)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookID", clientInfo_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", clientInfo_name.Text);
                            cmd.Parameters.AddWithValue("@email", clientInfo_email.Text);
                            cmd.Parameters.AddWithValue("@contact", clientInfo_contactNum.Text);
                            cmd.Parameters.AddWithValue("@gender", clientInfo_gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@houseID", houseData1.houseID);
                            cmd.Parameters.AddWithValue("@rent", houseData1.rentAmount);
                            cmd.Parameters.AddWithValue("@statusP", "Paid");
                            cmd.Parameters.AddWithValue("@status", "Rent Approved");
                            cmd.Parameters.AddWithValue("@dateStart", houseData1.fromDate);
                            cmd.Parameters.AddWithValue("@dateEnd", houseData1.toDate);



                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@dateBook", today);

                            cmd.ExecuteNonQuery();

                            UpdateHouseStatus();

                            MessageBox.Show("Booked successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }

                    }
                }
            }

        }

        public void UpdateHouseStatus()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE addHouse SET status = @status WHERE house_id = @houseID";

                using (SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@houseID", houseData1.houseID);

                    cmd.ExecuteNonQuery();
                }
            }
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
            if (clientInfo_name.Text == "" || clientInfo_gender.SelectedIndex == -1 ||
                clientInfo_email.Text == "" || clientInfo_contactNum.Text == "")
            {
                MessageBox.Show("Please fill all required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string bookID = clientInfo_bookID.Text;
            string fullName = clientInfo_name.Text;
            string email = clientInfo_email.Text;
            string contact = clientInfo_contactNum.Text;
            string gender = clientInfo_gender.SelectedItem.ToString();

            // Retrieve house-related information
            string houseID = houseData1.houseID; // Assuming houseData1 is accessible and has these properties
            string rent = houseData1.rent;
            string initial = houseData1.deposit; // You might need to get this value from elsewhere
            DateTime startOfRent = houseData1.fromDate;
            DateTime endOfRent = houseData1.toDate;
            string totalPrice = houseData1.rentAmount; // Calculate this based on rent and initial

            printPreviewMainFrom printForm = new printPreviewMainFrom(bookID, fullName, email, contact, gender,
                                                                        houseID, rent, initial, startOfRent, endOfRent, totalPrice);



            
            printForm.ShowDialog();
        }

    }
}
