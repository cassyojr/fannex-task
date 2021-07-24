using Domain.Entity;
using Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IVehicleRepository : IGenericRepository<Vehicle>
    {
        Task<List<Vehicle>> GetByFilterAsync(List<QueryOperator> filters);
    }
}
