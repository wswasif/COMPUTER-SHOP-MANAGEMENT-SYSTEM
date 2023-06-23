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
    public partial class customerpage : Form
    {
        public customerpage()
        {
            InitializeComponent();
        }

        private void customerpage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM productdetails ", con);
            DataTable dtb1 = new DataTable();
            sqlda.Fill(dtb1);
            newtable.DataSource = dtb1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchase pur = new purchase();
            pur.ShowDialog();
        }

        private void newtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
