using Domain.Entity;
using Domain.Model;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ApplicationContext context) : base(context)
        {
        }

        public async Task<List<Vehicle>> GetByFilterAsync(List<QueryOperator> filters)
        {
            filters = filters ?? new List<QueryOperator>();

            var query = DbSet.AsQueryable();

            foreach (var filter in filters)
            {
                if (filter.Operator == Operators.Equal)
                {
                    if (filter.Field.ToLower() == "brand") query = query.Where(x => EF.Functions.Like(x.Brand, $"%{filter.Value}%"));
                    else if (filter.Field.ToLower() == "model") query = query.Where(x => EF.Functions.Like(x.Model, $"%{filter.Value}%"));
                    else if (filter.Field.ToLower() == "year") query = query.Where(x => x.Year == Convert.ToInt32(filter.Value));
                    else if (filter.Field.ToLower() == "mileage") query = query.Where(x => x.Mileage == Convert.ToInt64(filter.Value));
                }
                else if (filter.Operator == Operators.GreatThan)
                {
                    var value = ConvertNumberValue(filter.Value);

                    if (filter.Field.ToLower() == "year") query = query.Where(x => x.Year > Convert.ToInt32(filter.Value));
                    else if (filter.Field.ToLower() == "mileage") query = query.Where(x => x.Mileage > Convert.ToInt64(filter.Value));
                }
                else if (filter.Operator == Operators.LessThan)
                {
                    var value = ConvertNumberValue(filter.Value);

                    if (filter.Field.ToLower() == "year") query = query.Where(x => x.Year < Convert.ToInt32(filter.Value));
                    else if (filter.Field.ToLower() == "mileage") query = query.Where(x => x.Mileage < Convert.ToInt64(filter.Value));
                }
            }

            return await query.ToListAsync();
        }

        private long ConvertNumberValue(string value)
        {
            var isParsed = long.TryParse(value, out var parsedValue);

            if (!isParsed) throw new ArgumentException($"Data: {value} cannot be compared with great than or less than because its not a number");

            return parsedValue;
        }
    }
}
