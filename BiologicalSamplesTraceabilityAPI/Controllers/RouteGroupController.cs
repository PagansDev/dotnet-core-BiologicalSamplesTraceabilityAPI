using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.RouteGroup;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiologicalSamplesTraceabilityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteGroupController : ControllerBase
    {
        private readonly IRouteGroup _routeGroup;

        public RouteGroupController(IRouteGroup routeGroup)
        {
            _routeGroup  =  routeGroup;
        }

        [HttpGet("GetAllRouteGroups")]
        public async Task<ActionResult<ResponseModel<List<RouteGroup>>>> GetAllRouteGroups()
        {
            var routeGroups = await _routeGroup.GetAllRouteGroups();
            return Ok(routeGroups);
        }
    }
}
