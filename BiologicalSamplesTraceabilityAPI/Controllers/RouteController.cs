using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.Routes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiologicalSamplesTraceabilityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRoute _route;
        public RouteController(IRoute route)
        {
            _route = route;
            
        }

        [HttpGet("GetAllRoutes")]
        public async Task<ActionResult<ResponseModel<List<Models.Route>>>> GetAllRoutes()
        {
            var routes = await _route.GetAllRoutes();
            return Ok(routes);
        }

    }
}
