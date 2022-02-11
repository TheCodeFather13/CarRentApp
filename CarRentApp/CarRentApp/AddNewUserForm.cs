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
    public partial class AddNewUserForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();
        private ManageUsers _manageUsers;

        public AddNewUserForm( ManageUsers manageUsers)
        {
            InitializeComponent();
            _manageUsers = manageUsers ;
        }

        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {

            var roles = _dbContext.Roles.ToList();
            cbRole.DataSource = roles;
            cbRole.ValueMember = "Id";
            cbRole.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = tbUserName.Text;
                var roleId = (int)cbRole.SelectedValue;
                var hashPassword = Utils.DefaultHashPassword();
                var user = new User
                {                    
                    UserName = userName,
                    Password = hashPassword,
                    IsActive = true                 
                };
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                var userRole = new UserRole
                {
                    UserId = user.Id,
                    RoleId = roleId,                       
                };
                _dbContext.UserRoles.Add(userRole);
                _dbContext.SaveChanges();
                MessageBox.Show("User has been added!");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Some error, try again!");
            }
        }
    }
}
