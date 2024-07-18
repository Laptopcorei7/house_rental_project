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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to Log Out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginFile loginForm = new LoginFile();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_addUser1.Visible = false;
            admin_customer1.Visible = false;
            admin_addHouses1.Visible = false;

            admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;
            if(adDashboard != null)
            {
                adDashboard.refreshData();
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            admin_addUser1.Visible = true;
            admin_dashboard1.Visible = false;
            admin_customer1.Visible = false;
            admin_addHouses1.Visible = false;

            admin_addUser adUser = admin_addUser1 as admin_addUser;
            if (adUser != null)
            {
                adUser.refreshData();
            }
        }

        private void addHouse_btn_Click(object sender, EventArgs e)
        {
            admin_addHouses1.Visible = true;
            admin_addUser1.Visible = false;
            admin_dashboard1.Visible = false;
            admin_customer1.Visible = false;

            admin_addHouses adHouses = admin_addHouses1 as admin_addHouses;
            if (adHouses != null)
            {
                adHouses.refreshData();
            }
        }

        private void cutomers_btn_Click(object sender, EventArgs e)
        {
            admin_customer1.Visible = true;
            admin_addHouses1.Visible = false;
            admin_addUser1.Visible = false;
            admin_dashboard1.Visible = false;

            admin_customer adCustomer = admin_customer1 as admin_customer;
            if (adCustomer != null)
            {
                adCustomer.refreshData();
            }
        }
    }
}
