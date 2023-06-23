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
    public partial class signuppage : Form
    {
        public signuppage()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            string sql = "INSERT INTO signup (Name,DateOfBirth,Gender,[E-Mail],PhoneNO,Address,Username,Password) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.VarChar,50).Value = name.Text;
                cmd.Parameters.Add("@param2", SqlDbType.DateTime).Value = datetime.Text;
                cmd.Parameters.Add("@param5", SqlDbType.Int).Value = int.Parse(phoneno.Text);
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = email.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = address.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = username.Text;
                cmd.Parameters.Add("@param8", SqlDbType.VarChar, 50).Value = password.Text;

                if (male.Checked)
                {
                    cmd.Parameters.Add("@param3", SqlDbType.Int).Value = 0;
                }
                else
                {
                    cmd.Parameters.Add("@param3", SqlDbType.Int).Value = 1;
                }

                


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();



                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM signup ", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                signup12.DataSource = dtb1;
                
            }
        }
    }
}
