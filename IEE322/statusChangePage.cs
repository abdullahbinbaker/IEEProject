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
    public partial class statusChangePage : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public statusChangePage()
        {
            InitializeComponent();
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
              

                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"update loans set status=@status where loanId=@id";

                    cmd.Parameters.AddWithValue("@id", loanId.Text);
                    cmd.Parameters.AddWithValue("@status", "rejected");

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        this.Close();

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                        conn.Close();
                    }
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(conn1))
            {
                
                using (SqlCommand cmd = new SqlCommand())
            {

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"update loans set status=@status where loanId=@id";

                cmd.Parameters.AddWithValue("@id", loanId.Text);
                cmd.Parameters.AddWithValue("@status", "accepted");
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                        this.Close();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                        conn.Close();
                    }
            }
        }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
