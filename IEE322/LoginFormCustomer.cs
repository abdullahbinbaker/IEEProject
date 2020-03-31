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
    public partial class LoginFormCustomer : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public LoginFormCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SignupForm().Show();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select * from customers where customerId=@id and password=@password", conn);
                command.Parameters.AddWithValue("@id", idNumber.Text);
                command.Parameters.AddWithValue("@password",password.Text);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        LoanForm loan = new LoanForm();
                        loan.name.Text = reader["name"].ToString();
                        loan.idNumber.Text= reader["customerId"].ToString();
                        loan.birthDate.Text = reader["birthDate"].ToString();
                        loan.mobileNumber.Text= reader["mobileNumber"].ToString();
                        loan.nationality.Text= reader["nationality"].ToString();
                        loan.address.Text= reader["address"].ToString();
                        loan.email.Text= reader["email"].ToString();
                        loan.salary.Text= reader["salary"].ToString();
                        loan.Show();
                        idNumber.Text = "";
                        password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("id or password is wrong");
                        idNumber.Text = "";
                        password.Text = "";
                    }
                }
            }


                }

        private void label2_Click(object sender, EventArgs e)
        {
            new EmailForm().Show();


        }
    }
}
