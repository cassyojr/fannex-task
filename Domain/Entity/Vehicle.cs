using System;

namespace Domain.Entity
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public long Mileage { get; set; }
    }
}
