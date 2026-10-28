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
            bookHouse_plan.SelectedItem = "Monthly";
            // No data loading here: the VS designer runs this constructor. The main form calls refreshData().
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

        private houseData? selectedHouse;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                houseData house = (houseData)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                selectedHouse = house;

                bookHouse_houseID.Text = house.HouseId;
                bookHouse_name.Text = house.Name;
                bookHouse_address.Text = house.Address;
                bookHouse_rent.Text = house.Rent.ToString("0.00");
                bookHouse_dailyRent.Text = house.DailyRent.ToString("0.00");
                bookHouse_deposit.Text = house.Deposit.ToString("0.00");
                bookHouse_status.Text = house.BookedUntil is DateTime until
                    ? $"Booked until {until:d MMM yyyy}"
                    : house.Status;
                bookHouse_total.Text = "0.00";

                bookHouse_imageView.ImageLocation = house.Image;
            }
        }

        // Builds the booking from the screen as it is right now, so dates and total always match.
        private Booking? CurrentBooking()
        {
            if (selectedHouse == null)
            {
                MessageBox.Show("Please select a house first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Booking(selectedHouse.HouseId, bookHouse_start.Value.Date, bookHouse_end.Value.Date,
                (string)bookHouse_plan.SelectedItem!, selectedHouse.Rent, selectedHouse.DailyRent, selectedHouse.Deposit);
        }

        private void bookHouse_scheduleBtn_Click(object sender, EventArgs e)
        {
            Booking? booking = CurrentBooking();
            if (booking == null) return;

            if (booking.End <= booking.Start)
            {
                MessageBox.Show("The end date must be after the start date.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookHouse_total.Text = "0.00";
                return;
            }

            bookHouse_total.Text = booking.Total.ToString("0.00");
        }

        private void bookHouse_bookHouseBtn_Click(object sender, EventArgs e)
        {
            Booking? booking = CurrentBooking();
            if (booking == null) return;

            string? problem = booking.FindProblem();
            if (problem != null)
            {
                MessageBox.Show(problem, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bookHouse_total.Text = booking.Total.ToString("0.00");

            using (clientInfo ciForm = new clientInfo(booking))
            {
                ciForm.ShowDialog(this);
            }

            clearField();
            refreshData();
        }

        public void clearField()
        {
            selectedHouse = null;
            bookHouse_houseID.Text = "---------";
            bookHouse_name.Text = "---------";
            bookHouse_address.Text = "---------";
            bookHouse_rent.Text = "0.00";
            bookHouse_dailyRent.Text = "0.00";
            bookHouse_plan.SelectedItem = "Monthly";
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
