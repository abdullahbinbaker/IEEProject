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

namespace IEE322
{
    public partial class SignupForm : Form
    {

        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public SignupForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select customerId from customers where customerId=@id ", conn);
                command.Parameters.AddWithValue("@id", idNumber.Text);
               
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("CUSTOMER IS ALEADY REGISTERED");
                        conn.Close();
                        

                    }
                    else
                    {
                        conn.Close();
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = @"INSERT INTO customers(customerId,name,birthDate,mobileNumber,nationality,address,email,salary,password)
                            VALUES(@id,@name,@birthDate,@mobileNumber,@nationality,@address,@email,@salary,@password)";

                            cmd.Parameters.AddWithValue("@id", idNumber.Text);
                            cmd.Parameters.AddWithValue("@name", name.Text);
                            cmd.Parameters.AddWithValue("@birthDate", birthDate.Value);
                            cmd.Parameters.AddWithValue("@mobileNumber", Convert.ToInt32( mobileNumber.Text));
                            cmd.Parameters.AddWithValue("@nationality", nationality.Text);
                            cmd.Parameters.AddWithValue("@address", address.Text);
                            cmd.Parameters.AddWithValue("@email", email.Text);
                            cmd.Parameters.AddWithValue("@salary", salary1.Text);
                            cmd.Parameters.AddWithValue("@password", password.Text);
                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                name.Text = "";
                                idNumber.Text = "";
                                nationality.Text = "";
                                mobileNumber.Text = "";
                                address.Text = "";
                                email.Text = "";
                                salary1.Text = "";
                                password.Text = "";
                                MessageBox.Show("You Sccessfully create Your Account");
                                
                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show(ee.ToString());
                            }
                        }

                    }
                }

               

               
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
