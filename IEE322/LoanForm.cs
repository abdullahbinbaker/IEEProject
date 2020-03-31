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
    public partial class LoanForm : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public LoanForm()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {

                conn.Close();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO loans(customerId,amount,purpose,status)
                            VALUES(@customerId,@amount,@purpose,@status)";

                    cmd.Parameters.AddWithValue("@customerId", idNumber.Text);
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDouble(amount.Text));
                    cmd.Parameters.AddWithValue("@purpose", purpose.Text);
                    cmd.Parameters.AddWithValue("@status", "in progress");
                    
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
                        salary.Text = "";
                        amount.Text = "";
                        purpose.Text = "";


                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                }

            
        }
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
