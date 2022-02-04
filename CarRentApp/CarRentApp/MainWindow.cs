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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("ManageUsers"))
            {
                MessageBox.Show("Open the window");
            }
        }
    }
}
