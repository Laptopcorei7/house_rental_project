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
    public partial class admin_customer : UserControl
    {
        public admin_customer()
        {
            InitializeComponent();
            displayCustomerData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayCustomerData();
        }

        public void displayCustomerData()
        {
            customers_data cData = new customers_data();
            List<customers_data> listD = cData.customerDataList();

            dataGridView1.DataSource = listD;
        }
    }
}
