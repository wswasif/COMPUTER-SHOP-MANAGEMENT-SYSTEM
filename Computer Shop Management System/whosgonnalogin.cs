using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System
{
    public partial class whosgonnalogin : Form
    {
        public whosgonnalogin()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            LOGINPAGE lo = new LOGINPAGE();
            lo.ShowDialog();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            adminsignin lo = new adminsignin();
            lo.ShowDialog();
            
        }

        private void employee_Click(object sender, EventArgs e)
        {
            employeelogin el = new employeelogin();
            el.ShowDialog();
        }
    }
}
