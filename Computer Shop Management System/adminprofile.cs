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
    public partial class adminprofile : Form
    {
        public adminprofile()
        {
            InitializeComponent();
        }

        private void viewcatalogue_Click(object sender, EventArgs e)
        {
            catalogue ca = new catalogue();
            ca.ShowDialog();
        }

        private void ED_Click(object sender, EventArgs e)
        {
            employeeDetails ed = new employeeDetails();
            ed.ShowDialog();
        }
    }
}
