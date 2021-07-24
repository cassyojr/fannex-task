using Domain.Entity;
using Domain.Model;
using Domain.Repository;
using Domain.Services;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class VehicleService : IVehicleService
    {
        private const string QueryPattern = @"[a-zA-Z0-9]+[=<>]+[a-zA-Z0-9]+";

        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Vehicle> GetByIdAsync(int vehicleId) => await _vehicleRepository.GetByIdAsync(vehicleId);

        public async Task<IEnumerable<Vehicle>> GetAll() => await _vehicleRepository.GetAll();

        public async Task<List<Vehicle>> GetByFilterAsync(string query)
        {
            var hasValidOperators = CheckForValidQuery(query);

            if (!hasValidOperators) return null;

            var filters = GetValidFilters(query);

            return await _vehicleRepository.GetByFilterAsync(filters);
        }

        public bool CheckForValidQuery(string query)
        {
            if (string.IsNullOrEmpty(query)) return true;

            var regex = new Regex(QueryPattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(query);
        }

        private List<QueryOperator> GetValidFilters(string query)
        {
            if (string.IsNullOrEmpty(query)) return null;

            var regex = new Regex(QueryPattern, RegexOptions.IgnoreCase);

            var matches = regex.Matches(query);

            var filtersList = new List<QueryOperator>();

            foreach (Match match in matches)
            {
                string queryOperator;

                if (match.Value.Contains(Operators.Equal)) queryOperator = Operators.Equal;
                else if (match.Value.Contains(Operators.GreatThan)) queryOperator = Operators.GreatThan;
                else if (match.Value.Contains(Operators.LessThan)) queryOperator = Operators.LessThan;
                else break;

                var values = match.Value.Split(queryOperator);

                filtersList.Add(new QueryOperator
                {
                    Field = values[0],
                    Value = values[1],
                    Operator = queryOperator
                });
            }

            return filtersList;
        }
    }
}
