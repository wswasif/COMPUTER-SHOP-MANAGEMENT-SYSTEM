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
using System.IO;
namespace Computer_Shop_Management_System
{
    public partial class productdetails : Form
    {
        public productdetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            string sql = "INSERT INTO productdetails (P_Name,P_ID,P_Details,P_Price,P_Picture) VALUES(@param1,@param2,@param3,@param4,@param5)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                byte[] images = null;
                FileStream stream = new FileStream(ppicture.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = pname.Text;
                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = int.Parse(pid.Text);
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = pdetails.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = pprice.Text;
                cmd.Parameters.Add("@param5", SqlDbType.Binary).Value = images;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

               

                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM productdetails ", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                producttable.DataSource = dtb1;

                


            }
        }

        private void producttable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void producttable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            pname.Text = producttable.Rows[RowIndex].Cells[1].Value.ToString();
            pid.Text = producttable.Rows[RowIndex].Cells[2].Value.ToString();
            pdetails.Text = producttable.Rows[RowIndex].Cells[3].Value.ToString();
            pprice.Text = producttable.Rows[RowIndex].Cells[4].Value.ToString();
            ppicture.Text = producttable.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void DETAILS_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM productdetails ", con);
            DataTable dtb1 = new DataTable();
            sqlda.Fill(dtb1);
            producttable.DataSource = dtb1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            String imglocation = " ";
            SqlCommand cmd;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                ppicture.ImageLocation = imglocation;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

            //Generating SQL Query
            //string sql = "DELETE FROM employeedetails WHERE E_Name = @E_Name, E_DateOfBirth=@E_DateOfBirth,E_ID=@E_ID,E_PhoneNo=@E_PhoneNo,E_Address=@E_Address,E_Salary=@E_Salary,E_Schedule = @E_Schedule " ;
            //using (SqlCommand cmd = new SqlCommand(sql, con))

            String st = "DELETE FROM productdetails WHERE P_ID = @P_id";

            SqlCommand cmd = new SqlCommand(st, con);
            con.Open();
            try
            {
                cmd.Parameters.AddWithValue("@P_ID", pid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection();

                con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";


                con.Open();
                using (SqlCommand cmd =
                    new SqlCommand("UPDATE productdetails SET P_Name=@P_Name , P_Details =@P_Details , P_Price = @P_Price  " +
                        " WHERE P_ID=@P_ID", con))
                {

                    cmd.Parameters.AddWithValue("@P_Name", pname.Text);
                    cmd.Parameters.AddWithValue("@P_ID", pid.Text);
                    cmd.Parameters.AddWithValue("@P_Details", pdetails.Text);
                    cmd.Parameters.AddWithValue("@P_Price", pprice.Text);
                    //cmd.Parameters.AddWithValue("@P_Picture", ppicture.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Database has rows");
                    }
                    //rows number of record got updated
                    MessageBox.Show("updated Successfully");
                }

            }
            catch (SqlException ex)
            {
                //Log exception
                //Display Error message
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            purchase pc = new purchase();
            pc.ShowDialog();
                
        }
    }
}
