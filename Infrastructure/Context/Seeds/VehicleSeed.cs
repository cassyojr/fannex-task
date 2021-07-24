using Domain.Entity;
using System;
using System.Collections.Generic;

namespace Infrastructure.Context.Seeds
{
    internal static class VehicleSeed
    {
        public static IEnumerable<Vehicle> Seeds = new List<Vehicle>()
        {
            new Vehicle { Id = Guid.NewGuid(), Brand = "Volkswagen", Model = "Golf", Year = 2009, Mileage = 100234 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Volkswagen", Model = "Polo", Year = 2010, Mileage = 59001 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Volkswagen", Model = "Jetta", Year = 2015, Mileage = 10234  },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Volkswagen", Model = "Gol", Year = 2018, Mileage = 26050 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Fiat", Model = "Uno", Year = 2019, Mileage = 14200 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Fiat", Model = "Argo", Year = 2020, Mileage = 5502 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Fiat", Model = "Mobi", Year = 2018, Mileage = 34508 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Fiat", Model = "Siena", Year = 2012, Mileage = 85745 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Cruze", Year = 2018, Mileage = 66520 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Onix", Year = 2020, Mileage = 33200 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Tracker", Year = 2017, Mileage = 66504 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Spin", Year = 2015, Mileage = 468500 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Camaro", Year = 2016, Mileage = 22500 },
            new Vehicle { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Cobalt", Year = 2018, Mileage = 56252 }
        }
        .ToArray();
    }
}
