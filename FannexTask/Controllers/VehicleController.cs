using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FannexTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string query)
        {
            if (!ModelState.IsValid) return BadRequest("Invalid informations");

            var hasValidOperators = _vehicleService.CheckForValidQuery(query);
            if (!hasValidOperators) return BadRequest("Invalid filters, please use one of the following operators: =, <, >");

            var vehicles = await _vehicleService.GetByFilterAsync(query);

            return Ok(vehicles);
        }
    }
}
