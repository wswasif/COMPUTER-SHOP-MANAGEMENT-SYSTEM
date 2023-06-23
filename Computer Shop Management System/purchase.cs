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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            string sql = "INSERT INTO invoice (P_ID,Quantity) VALUES(@param1,@param2)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(pid.Text);
                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = int.Parse(quantity.Text);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();



                //SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM productdetails ", con);
                //DataTable dtb1 = new DataTable();
                //sqlda.Fill(dtb1);
                //producttable.DataSource = dtb1;
                purchaseconfirmation pc = new purchaseconfirmation();
                pc.ShowDialog();
            }
        }
    }
}
