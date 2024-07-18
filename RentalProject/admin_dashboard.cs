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
using static RentalProject.houseData;

namespace RentalProject
{
    public partial class admin_dashboard : UserControl
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabe\\OneDrive\\Documents\\house.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_dashboard()
        {
            InitializeComponent();

            displayTotalStaff();
            displayAvailableHouses();
            displayProfitsToday();
            displayProfitsTotal();
            displayAllHouses();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayTotalStaff();
            displayAvailableHouses();
            displayProfitsToday();
            displayProfitsTotal();
            displayAllHouses();
        }

            public void displayAllHouses()
        {
            DatabaseAccess dbAccess = new DatabaseAccess();
            List<houseData> listD = dbAccess.GetHouseDataList();

            dataGridView1.DataSource = listD;
        }

        public void displayTotalStaff()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Staff'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        totalStaff.Text = result.ToString();
                    }
                }
            }
        }

        public void displayAvailableHouses()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM addHouse WHERE status = 'Active' OR status = 'Available'";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        availableHouses.Text = result.ToString();
                    }
                }
            }
        }

        public void displayProfitsToday()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(rent_amount) FROM customers WHERE date_book = @dbook";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dbook", today);


                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        todaysProfit.Text = $"${result.ToString()}";
                    }
                }
            }
        }


        public void displayProfitsTotal()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT SUM(rent_amount) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalProfit.Text = $"${result.ToString()}";
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
