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
    public partial class purchaseconfirmation : Form
    {
        public purchaseconfirmation()
        {
            InitializeComponent();
        }

        private void purchaseconfirmation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM invoice ", con);
            DataTable dtb1 = new DataTable();
            sqlda.Fill(dtb1);
            confirm.DataSource = dtb1;
        }
    }
}
