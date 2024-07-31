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
    public partial class staff_bookHouse : UserControl
    {
        public staff_bookHouse()
        {
            InitializeComponent();
            displayHouse();
        }

        public void displayHouse()
        {
            DatabaseAccess dbAccess = new DatabaseAccess();
            List<houseData> listD = dbAccess.GetHouseDataList();

            dataGridView1.DataSource = listD;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayHouse();
        }

        private int getID = 0;
        private decimal regprice;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                bookHouse_houseID.Text = row.Cells[1].Value.ToString();
                bookHouse_name.Text = row.Cells[2].Value.ToString();
                bookHouse_address.Text = row.Cells[4].Value.ToString();
                bookHouse_rent.Text = row.Cells[7].Value.ToString();
                bookHouse_deposit.Text = row.Cells[8].Value.ToString();
                bookHouse_status.Text = row.Cells[11].Value.ToString();

                regprice = Convert.ToDecimal(row.Cells[7].Value.ToString());

                bookHouse_imageView.ImageLocation = row.Cells[9].Value.ToString();
            }
        }

        private void bookHouse_scheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookHouse_start.Value;
            DateTime toDate = bookHouse_end.Value;

            int totalMonths = ((toDate.Year - fromDate.Year) * 12) + toDate.Month - fromDate.Month;

            if (toDate.Day < fromDate.Day)
            {
                totalMonths--;
            }

            decimal totalPrice = (regprice * totalMonths);

            if (totalPrice < 0)
            {
                MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                bookHouse_total.Text = "0.00";
            }
            else
            {
                bookHouse_total.Text = (regprice * totalMonths).ToString("0.00");
            }
        }

        private void bookHouse_bookHouseBtn_Click(object sender, EventArgs e)
        {
            if (regprice == 0 || bookHouse_total.Text == "0.00")
            {
                MessageBox.Show("Please fill all correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookHouse_status.Text != "Available")
            {
                MessageBox.Show("The house is unavailable", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                houseData1.houseID = bookHouse_houseID.Text;
                houseData1.fromDate = bookHouse_start.Value;
                houseData1.toDate = bookHouse_end.Value;
                houseData1.rentAmount = bookHouse_total.Text;
                houseData1.rent = bookHouse_rent.Text;
                houseData1.deposit = bookHouse_deposit.Text;
                Form formbg = new Form();

                try
                {
                    using (clientInfo ciForm = new clientInfo())
                    {
                        ciForm.Owner = formbg;
                        ciForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    formbg.Dispose();
                }
            }
        }

        public void clearField()
        {
            bookHouse_houseID.Text = "---------";
            bookHouse_name.Text = "---------";
            bookHouse_address.Text = "---------";
            bookHouse_rent.Text = "0.00";
            bookHouse_deposit.Text = "0.00";
            bookHouse_status.Text = "---------";
            bookHouse_total.Text = "0.00";

            bookHouse_imageView.Image = null;
        }

        private void bookHouse_clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }
    }
}
