using System;

namespace CarRentApp.Entities
{
    public class CarRentalRecord
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal Cost { get; set; }
        public int? TypesOfCarId { get; set; }
        public virtual TypesOfCar TypesOfCar { get; set; }
    }
}