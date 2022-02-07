using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbUsername.Text;
                var password = tbPassword.Text;
                var hashPassword = Utils.HashPassword(password);
                //Check for matching username, password and active flag
                var user = "Michael";
                if(user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {                
                  var mainWindow = new MainWindow();
                  mainWindow.Show();
                  this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something gone wrong!Please contact administration");
               
            }           
        }  

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {         
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                 // MessageBox.Show("Please fill form");
                 
            }
            else
            {
               btnLogin.Enabled = true;
               btnLogin.Select();
            }

            
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tbUsername.Text))
            //{
            //    tbUsername.Text = "Please fill username";
            //}
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                tbUsername.Text = "Please fill username";
            }
        }
    }
}
