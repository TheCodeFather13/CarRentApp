using CarRentApp.Entities;
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
    public partial class MainWindowForm : Form
    {
        private LoginForm _login;
        public string roleName;
        public User user;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        public MainWindowForm(LoginForm login, User user)
        {
            InitializeComponent();
            _login = login;
            this.user = user;
            roleName = "admin"; // get role from user
           // MessageBox.Show(this.user + " " + roleName);
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
               // manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }
    }
}
