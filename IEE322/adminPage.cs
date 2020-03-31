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
    public partial class adminPage : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public adminPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statusChangePage change = new statusChangePage();
            string customerId = null;
            using (SqlConnection conn = new SqlConnection(conn1))
            {
               
                conn.Open();

                SqlCommand command = new SqlCommand("select * from loans where loanId=@id ", conn);
                command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                     
                        change.amount.Text = reader["amount"].ToString();
                        change.purpose.Text = reader["purpose"].ToString();
                        change.loanId.Text = reader["loanId"].ToString();

                        customerId = reader["customerId"].ToString();
                    }
                    conn.Close();
                }
            }

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select * from customers where customerId=@customerId ", conn);
                command.Parameters.AddWithValue("@customerId", customerId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        

                        change.name.Text = reader["name"].ToString();
                        change.idNumber.Text = reader["customerId"].ToString();
                        change.birthDate.Text = reader["birthDate"].ToString();
                        change.mobileNumber.Text = reader["mobileNumber"].ToString();
                        change.nationality.Text = reader["nationality"].ToString();
                        change.address.Text = reader["address"].ToString();
                        change.email.Text = reader["email"].ToString();
                        change.salary.Text = reader["salary"].ToString();

                    }
                    conn.Close();
                    
                }
            }
            change.Show();

            

        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }
    }
}
