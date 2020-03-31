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
    public partial class LoanStatus : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public LoanStatus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select loanId,amount,purpose,status from loans where customerId=@id ", conn);
                command.Parameters.AddWithValue("@id", idNumber.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int rowIndex = 0;
                    if (reader.Read())
                    {
                        var row = new DataGridViewRow();
                        dataGridView1.Rows.Add(row);
                        dataGridView1.Rows[rowIndex].Cells[0].Value = reader["loanId"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[1].Value = reader["amount"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = reader["purpose"].ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = reader["status"].ToString();
                        
                        rowIndex++;

                        while (reader.Read())
                        {
                            var row1 = new DataGridViewRow();
                            dataGridView1.Rows.Add(row1);
                            dataGridView1.Rows[rowIndex].Cells[0].Value = reader["loanId"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[1].Value = reader["amount"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[2].Value = reader["purpose"].ToString();
                            dataGridView1.Rows[rowIndex].Cells[3].Value = reader["status"].ToString();

                            rowIndex++;
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("id or password is wrong");
                    }
                }
            }


        }
    }
}
