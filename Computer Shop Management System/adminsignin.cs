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
namespace Computer_Shop_Management_System
{
    public partial class adminsignin : Form
    {
        public adminsignin()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            adminsignup bla = new adminsignup();
            bla.ShowDialog();

        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-F0FMCLK\\SQLEXPRESS;AttachDbFilename=computershop;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "Select * from adminsignup Where UserID = '" + userid.Text.Trim() + "' and Password = '" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            // if (dtbl.Rows.Count == 1)
            if (dtbl.Rows.Count > 0)
            {
                employeeDetails ed = new employeeDetails();
                this.Hide();
                ed.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
