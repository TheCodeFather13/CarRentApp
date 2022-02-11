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
        private CarRentDbContext _dbContext = new CarRentDbContext();
        private int _id;

        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgvUserList.SelectedRows[0].Cells["id"].Value;
                // var user = 1;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        public void PopulateGrid()
        {
            var users = _dbContext.Users.Select(x => new 
            { x.Id, 
              x.UserName, 
              // RoleName = x.UserRoles.FirstOrDefault().Role.Name
              x.UserRoles.FirstOrDefault().Role.Name,
              x.IsActive}).ToList();
            dgvUserList.DataSource = users;
            dgvUserList.Columns["Id"].Visible = false;
            dgvUserList.Columns["IsActive"].HeaderText = "Active";
            dgvUserList.Columns["Name"].HeaderText = "Role Name";
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
          PopulateGrid();
        }
    }
}
