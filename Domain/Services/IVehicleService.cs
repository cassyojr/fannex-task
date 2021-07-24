using Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IVehicleService 
    {
        /// <summary>
        /// Asynchronously get vehicles with filter.
        /// </summary>
        /// <param name="query">String containing the filters to be applied, they can be '=' or '<' or '>' separated by comma to be executed together</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// Task result containing the list of filtered objects or null if none was found.
        /// </returns>
        Task<List<Vehicle>> GetByFilterAsync(string query);

        /// <summary>
        /// Verify if there is any valid operator inside query.
        /// </summary>
        /// <param name="query">String containing the filters to be applied, they can be '=' or '<' or '>' separated by comma to be executed together</param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// Task result containing the 'True' if any valid operator was found, otherwise 'False'.
        /// </returns>
        bool CheckForValidQuery(string query);
    }
}
