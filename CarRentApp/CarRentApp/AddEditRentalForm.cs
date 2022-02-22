using CarRentApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class AddEditRentalForm : Form
    {
        private CarRentDbContext _carRentDbContext = new CarRentDbContext();
        private bool _isEditMode;
        private CarRentalRecord _carRentalRecord;

        public AddEditRentalForm(CarRentalRecord carRentalRecord)
        {
            InitializeComponent();
            _carRentalRecord = carRentalRecord;
            // Change button name
            btnSave.Text = "Update";
            // Change form name
            this.Text = "EditRentalForm";
            tbCustomerName.Text = _carRentalRecord.CustomerName;
            tbCost.Text = _carRentalRecord.Cost.ToString();
            dtpDataRented.Text = _carRentalRecord.DateRented.Value.ToString();
            dtpDataReturned.Text = _carRentalRecord.DateReturned.Value.ToString();
            cbTypeOfCar.SelectedValue = _carRentalRecord.TypesOfCarId.ToString();
        }

        public AddEditRentalForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            // tbCustomerName.BackColor = Color.Transparent;

            // SetStyle(ControlStyles.SupportsTransparentBackColor);
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customerName = tbCustomerName.Text;
                var cost = Convert.ToDecimal(tbCost.Text);
                var dateRented = dtpDataRented.Value;
                var dateReturned = dtpDataReturned.Value;
                var typeOfCarId = (int)cbTypeOfCar.SelectedValue;

                if(string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show("Fill field: (Customer Name)");
                }

                if (cost <= 0)
                {
                    MessageBox.Show("Fill field: (Cost)");
                }

                if (dateReturned < dateRented)
                {
                    MessageBox.Show("Back in time is not working, DAMN YOU!");
                }

                var car = new CarRentalRecord()
                {
                    CustomerName = customerName,
                    Cost = cost,
                    DateRented = dateRented,
                    DateReturned = dateReturned,
                    TypesOfCarId = typeOfCarId,
                };

                if(_carRentalRecord != null)
                {
                    _carRentalRecord.CustomerName = customerName;
                    _carRentalRecord.DateRented = dateRented;
                    _carRentalRecord.DateReturned = dateReturned;
                    _carRentalRecord.TypesOfCarId = typeOfCarId;
                    _carRentalRecord.Cost = cost;

                    // Update
                    _carRentDbContext.CarRentalRecords.AddOrUpdate(_carRentalRecord);
                    _carRentDbContext.SaveChanges();
                }
                else
                {
                     // Insert in database
                        _carRentDbContext.CarRentalRecords.Add(car);
                        _carRentDbContext.SaveChanges();
                }               
            }
            catch (Exception)
            {

                throw;
            }         
            // MessageBox.Show(customerName);
        }

        private void AddEditRentalForm_Load(object sender, EventArgs e)
        {
            var cars = _carRentDbContext.TypesOfCars
                .Select(x=> new { x.Id, Name = x.Make + " " + x.Model}).ToList();

            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "Id";
            cbTypeOfCar.DataSource = cars;

            //var path = new GraphicsPath();
            //path.AddEllipse(0, 0, Width, Height);
            //Region = new Region(path);
        }
    }
}
