using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.RouteType;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Services.Routes
{
    public class RouteService : IRoute
    {
        private readonly AppDbContext _context;

        public RouteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<Models.Route>>> GetAllRoutes()
        {

            ResponseModel<List<Models.Route>> response = new ResponseModel<List<Models.Route>>();
            try
            {


                var route = await _context.Routes.ToListAsync();

                if (route == null)
                {
                    response.Message = "No routes were found!";
                    return response;
                }

                response.Data = route;
                response.Message = "All routes were collected!";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;


            }
        }
    }
}
