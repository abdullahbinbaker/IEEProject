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
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace IEE322
{
    public partial class EmailForm : Form
    {
        string conn1 = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        string senderEmail = ConfigurationSettings.AppSettings["senderEmail"];
        string senderEmailPassword = ConfigurationSettings.AppSettings["senderEmailPassword"];


        public EmailForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn1))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("select * from customers where customerId=@id and email=@email", conn);
                command.Parameters.AddWithValue("@id", idNumber.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        try
                        {
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mail.From = new MailAddress(senderEmail);
                            mail.To.Add(reader["email"].ToString());
                            mail.Subject = "Password information";
                            mail.Body = "Good Morning/Good Afternoon MR/Mrs :  " +reader["name"].ToString()+ "\r\n" + " You Dont need To worry this is your Password: " + reader["password"].ToString() + "\r\n" + " Please remember it "+ "\r\n" + " we hope to have a good day" ;

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential(senderEmail, senderEmailPassword);
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);
                            new ConfirmationForm().Show();
                        }catch(Exception m)
                        {
                            MessageBox.Show(m.ToString());
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
