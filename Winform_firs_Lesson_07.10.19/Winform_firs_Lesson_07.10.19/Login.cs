using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_firs_Lesson_07._10._19
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
           
            }
            else
            {
              
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUSername.Text;
            string password = txtPassword.Text;
            string enterName = "Javid";
            string enterPassword = "cavid123";
            
           
            if(username== enterName && password == enterPassword)
            {
               
                MessageBox.Show("Ad ve shifre duzgundur");
                txtUSername.Text = null;
                txtPassword.Text = null;
            }
            else if(username != enterName && password == enterPassword)
            {
                
                MessageBox.Show("Zehmet olmasa adinizi duzgun daxil edin");
                txtUSername.Text = null;
                txtPassword.Text = null;
            }
            else
            {
                

                MessageBox.Show("Zehmet olmasa shifrenizi duzgun daxil edin");
                txtUSername.Text = null;
                txtPassword.Text = null;
            }
            

        }
    }
}
