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
    public partial class AdminLoginForm : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select * from admin where adminId=@id and password=@password", conn);
                command.Parameters.AddWithValue("@id", idNumber.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   
                    int rowIndex = 0;
                    if (reader.Read())
                    {
                        adminPage admin = new adminPage();
                        conn.Close();
                        conn.Open();
                        SqlCommand command1 = new SqlCommand("select * from loans where status='in progress'", conn);

                        using (SqlDataReader reader2 = command1.ExecuteReader())
                        {

                            if(reader2.Read())
                            {
                                var row = new DataGridViewRow();
                                admin.dataGridView1.Rows.Add(row);
                                admin.dataGridView1.Rows[rowIndex].Cells[0].Value = reader2["loanId"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[1].Value = reader2["amount"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[2].Value = reader2["purpose"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[3].Value = reader2["status"].ToString();

                                rowIndex++;
                            }
                            while (reader2.Read())
                            {
                                var row = new DataGridViewRow();
                                admin.dataGridView1.Rows.Add(row);
                                admin.dataGridView1.Rows[rowIndex].Cells[0].Value = reader2["loanId"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[1].Value = reader2["amount"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[2].Value = reader2["purpose"].ToString();
                                admin.dataGridView1.Rows[rowIndex].Cells[3].Value = reader2["status"].ToString();

                                rowIndex++;
                            }
                        }
                        admin.Show();
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

    


       

               

       

    }
}
