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
    public partial class SearchArchiveForm : Form
    {
        private CarRentDbContext _dbContext = new CarRentDbContext();


        public SearchArchiveForm()
        {
            InitializeComponent();
        }

        private void SearchArchiveForm_Load(object sender, EventArgs e)
        {
             var dateTimeNow = DateTime.Now.AddDays(-3);        
             var carRentalRecord = _dbContext.CarRentalRecords
                            .Where(x => x.DateRented < DateTime.Now)
                            .Where(x => x.DateRented > dateTimeNow)
                            .Select(x => new
                            {
                                x.CustomerName,
                                x.Cost,
                                x.DateRented,
                                x.DateReturned,
                                Car = x.TypesOfCar.Make + " " + x.TypesOfCar.Model                            
                            }).ToList();
            dgvCarRents.DataSource = carRentalRecord;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var searchText = tbSearch.Text.Trim(); 
            if(!string.IsNullOrEmpty(searchText))
            {
                var carRentalRecord = _dbContext.CarRentalRecords
                            .Where(x => x.CustomerName.Contains(searchText) 
                            || x.TypesOfCar.Make.Contains(searchText))                                                                              
                            .Select(x => new
                            {
                                x.CustomerName,
                                x.Cost,
                                x.DateRented,
                                x.DateReturned,
                                Car = x.TypesOfCar.Make + " " + x.TypesOfCar.Model
                            }).ToList();
                dgvCarRents.DataSource = carRentalRecord;
            }
        }
    }
}
