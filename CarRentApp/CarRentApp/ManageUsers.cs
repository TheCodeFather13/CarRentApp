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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgvUserList.SelectedRows[0].Cells["id"].Value;
                var user = 1;
                // Query database for record
                // dbContext.Users.FirstOrDefault(x => x.id == id);
                var hashPassword = Utils.DefaultHashPassword();
                // User.Password = hashPassword;
                // dbContext.SaveChanges();
                MessageBox.Show("Password has been resert");
            }
            catch (Exception)
            {
                MessageBox.Show("Try again!");
            }
        }
    }
}
