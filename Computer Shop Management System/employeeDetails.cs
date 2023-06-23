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
    public partial class employeeDetails : Form
    {
        public employeeDetails()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
            string sql = "INSERT INTO employeedetails (E_name,E_DateOfBirth,E_Gender,E_ID,E_PhoneNO,E_Address,E_Salary,E_Schedule) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = ename.Text;
                cmd.Parameters.Add("@param2", SqlDbType.DateTime).Value = edob.Text;
                cmd.Parameters.Add("@param4", SqlDbType.Int).Value = int.Parse(eid.Text);
                cmd.Parameters.Add("@param5", SqlDbType.Int).Value = int.Parse(ephoneno.Text);
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = eaddress.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = esalary.Text;
                cmd.Parameters.Add("@param8", SqlDbType.VarChar, 50).Value = eschedule.Text;

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



                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM employeedetails ", con);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                showtable.DataSource = dtb1;

            }
        
        }

        private void remove_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

            //Generating SQL Query
            //string sql = "DELETE FROM employeedetails WHERE E_Name = @E_Name, E_DateOfBirth=@E_DateOfBirth,E_ID=@E_ID,E_PhoneNo=@E_PhoneNo,E_Address=@E_Address,E_Salary=@E_Salary,E_Schedule = @E_Schedule " ;
            //using (SqlCommand cmd = new SqlCommand(sql, con))
            
                String st = "DELETE FROM employeedetails WHERE E_ID = @E_id" ;

                SqlCommand cmd = new SqlCommand(st, con);
            con.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@E_ID", eid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void update_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlConnection con = new SqlConnection();

                con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";

               
                    con.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE employeedetails SET E_Name=@E_Name , E_Gender= @E_Gender , E_PhoneNo=@E_PhoneNo , E_Address=@E_Address , E_Salary = @E_Salary , E_Schedule = @E_Schedule "+ 
                            " WHERE E_ID=@E_ID", con))
                    {
                       
                        cmd.Parameters.AddWithValue("@E_Name", ename.Text);
                        //cmd.Parameters.AddWithValue("@E_DateOfBirth", edob.Text);
                        cmd.Parameters.AddWithValue("@E_Gender", male.Text);
                        cmd.Parameters.AddWithValue("@E_ID", eid.Text);
                        cmd.Parameters.AddWithValue("@E_PhoneNo", ephoneno.Text);
                        cmd.Parameters.AddWithValue("@E_Address", eaddress.Text);
                        cmd.Parameters.AddWithValue("@E_Salary", esalary.Text);
                        cmd.Parameters.AddWithValue("@E_Schedule", eschedule.Text);

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

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F0FMCLK\\SQLEXPRESS;database = computershop;integrated security = SSPI";
           
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM employeedetails ", con);
            DataTable dtb1 = new DataTable();
            sqlda.Fill(dtb1);
            showtable.DataSource = dtb1;
        }

        private void showtable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            ename.Text = showtable.Rows[RowIndex].Cells[1].Value.ToString();
            edob.Text = showtable.Rows[RowIndex].Cells[2].Value.ToString();
            male.Text = showtable.Rows[RowIndex].Cells[3].Value.ToString();
            eid.Text = showtable.Rows[RowIndex].Cells[4].Value.ToString();
            ephoneno.Text = showtable.Rows[RowIndex].Cells[5].Value.ToString();
            eaddress.Text = showtable.Rows[RowIndex].Cells[6].Value.ToString();
            esalary.Text = showtable.Rows[RowIndex].Cells[7].Value.ToString();
            eschedule.Text = showtable.Rows[RowIndex].Cells[8].Value.ToString();
            //ename.Text = showtable.Rows[RowIndex].Cells[0].Value.ToString();

        }

        private void showtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
