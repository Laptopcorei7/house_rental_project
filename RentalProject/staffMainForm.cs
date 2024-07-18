using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RentalProject
{
    public partial class staffMainForm : Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginFile loginForm = new LoginFile();
                loginForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_customer1.Visible = false;
            staff_bookHouse1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;
            if (adDashboard != null)
            {
                adDashboard.refreshData();
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            staff_bookHouse1.Visible = true;
            admin_dashboard1.Visible = false;
            admin_customer1.Visible = false;

            staff_bookHouse adBookHouse = staff_bookHouse1 as staff_bookHouse;
            if (adBookHouse != null)
            {
                adBookHouse.refreshData();
            }
        }

        private void cutomers_btn_Click(object sender, EventArgs e)
        {
            admin_customer1.Visible = true;
            staff_bookHouse1.Visible = false;
            admin_dashboard1.Visible = false;

            admin_customer adCustomer = admin_customer1 as admin_customer;
            if (adCustomer != null)
            {
                adCustomer.refreshData();
            }
        }
    }
}