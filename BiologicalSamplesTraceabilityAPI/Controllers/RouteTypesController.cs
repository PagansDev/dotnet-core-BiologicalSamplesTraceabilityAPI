using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.RouteType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiologicalSamplesTraceabilityAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RouteTypesController : ControllerBase
    {

        private readonly IRouteType _routeType;

        public RouteTypesController(IRouteType routeType) {

            _routeType = routeType;
        }


        [HttpGet("GetAllRouteTypes")]
        public async Task<ActionResult<ResponseModel<List<RouteType>>>> GetAllRouteTypes()
        {
            var routeTypes = await _routeType.GetAllRouteTypes();
            return Ok(routeTypes);
        }
    }
}
