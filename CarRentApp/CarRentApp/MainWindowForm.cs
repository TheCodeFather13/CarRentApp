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
        private CarRentDbContext _dbContext = new CarRentDbContext();

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
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                // manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void addRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalForm"))
            {
                var addRentalForm = new AddEditRentalForm();
                addRentalForm.Text = "Add Rental Form";
                addRentalForm.Show();
            }
        }

        private void editRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = (int)dgvRentalRecords.SelectedRows[0].Cells["Id"].Value;
            if (index < 0)
            {
                MessageBox.Show("Please select an item from the Grid");
            }
            else
            {
                var carRentalRecord = _dbContext.CarRentalRecords.FirstOrDefault(x => x.Id == index);
                if (carRentalRecord != null)
                {                    
                    if (!Utils.FormIsOpen("AddEditRentalForm"))
                    {                     
                        var addRentalForm = new AddEditRentalForm(carRentalRecord);
                        addRentalForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Record is missing");
                }
            }



        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // Load CarRecordsGrid
            var carRecords = _dbContext.CarRentalRecords
                .Select(x => new
                {
                    x.CustomerName,
                    x.Cost,
                    x.DateRented,
                    x.DateReturned,
                    x.Id,
                    Car = x.TypesOfCar.Make + " " + x.TypesOfCar.Model,
                    x.TypesOfCarId 
                })
                .ToList();
            dgvRentalRecords.DataSource = carRecords;
            dgvRentalRecords.Columns["Id"].Visible = false; // Скрыть колонку 
            dgvRentalRecords.Columns["TypesOfCarId"].Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MainWindowForm window = new MainWindowForm();
            window.Show();
            this.Hide();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("SearchArchiveForm"))
            {
               var searchArchiveForm = new SearchArchiveForm();
                searchArchiveForm.Show();
            }
           
        }
    }
}
