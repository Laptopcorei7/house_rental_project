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

namespace RentalProject
{
    public partial class clientInfo : Form
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabe\\OneDrive\\Documents\\house.mdf;Integrated Security=True;Connect Timeout=30";

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
        private void clientInfo_bookBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to book now?", "Information Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientInfo_name.Text == "" || clientInfo_gender.SelectedIndex == -1 ||
                clientInfo_email.Text == "" || clientInfo_contactNum.Text == "" || houseData1.houseID == "")
                {
                    MessageBox.Show("Please fiil all blank spaces.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customers" +
                            "(book_id, full_name, email,contact, gender, house_id, rent_amount, status_payment, status, " +
                            "date_start, date_end, date_book)" +
                            "VALUES(@bookID, @fullname, @email, @contact, @gender, @houseID, @rent, @statusP" +
                            ", @status, @dateStart, @dateEnd, @dateBook)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookID", clientInfo_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", clientInfo_name.Text);
                            cmd.Parameters.AddWithValue("@email", clientInfo_email.Text);
                            cmd.Parameters.AddWithValue("@contact", clientInfo_email.Text);
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
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE addHouse SET status = @status WHERE house_id = @houseID";

                using(SqlCommand cmd = new SqlCommand(updateStatus, connect))
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
    }
}
