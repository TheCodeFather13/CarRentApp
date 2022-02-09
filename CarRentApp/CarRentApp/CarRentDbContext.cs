using CarRentApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentApp
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext() : base("MyConnectionString")
        {

        }
        public virtual DbSet<CarRentalRecord> CarRentalRecords { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TypesOfCar> TypesOfCars { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }


    }
}
