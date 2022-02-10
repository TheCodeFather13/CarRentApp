namespace CarRentApp.Migrations
{
    using CarRentApp.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddCars : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.TypesOfCars.Add
            (new TypesOfCar
            {
                Make = "BMW",
                Model = "Veron",
                LicensePlateNumber = "252dwdw3",
                VIN = "e242sa",
                Year = 2016,
                CarRentalRecords = new List<CarRentalRecord>()
            });

            dbContext.TypesOfCars.Add
          (new TypesOfCar
          {
              Make = "Bugatti",
              Model = "X6",
              LicensePlateNumber = "rass423",
              VIN = "673dhc",
              Year = 2017,
              CarRentalRecords = new List<CarRentalRecord>()
          });

            dbContext.TypesOfCars.Add
          (new TypesOfCar
          {
              Make = "Mercedes",
              Model = "CLS",
              LicensePlateNumber = "ds8433",
              VIN = "eds5652sa",
              Year = 2020,
              CarRentalRecords = new List<CarRentalRecord>()
          });

            dbContext.SaveChanges();
        }
        
        public override void Down()
        {

        }
    }
}
