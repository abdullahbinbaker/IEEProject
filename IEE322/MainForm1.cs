using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEE322
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
       

      
        private void AdminLogIn_Click(object sender, EventArgs e)
        {
            new AdminLoginForm().Show();
        }

        private void loanStatusButton_Click(object sender, EventArgs e)
        {
            new LoanStatus().Show();
        }

        private void ApplyingForLoanButton_Click(object sender, EventArgs e)
        {
            new LoginFormCustomer().Show();
        }

        private void arabicButton_Click(object sender, EventArgs e)
        {

            var ChangeLanguage = new ChangeLanguage();
            ChangeLanguage.UpdateConfig("Language", "ar");
            Application.Restart();
        }

        private void englishButton_Click_1(object sender, EventArgs e)
        {

            var ChangeLanguage = new ChangeLanguage();
            ChangeLanguage.UpdateConfig("Language", "en");
            Application.Restart();
        }
    }
}
