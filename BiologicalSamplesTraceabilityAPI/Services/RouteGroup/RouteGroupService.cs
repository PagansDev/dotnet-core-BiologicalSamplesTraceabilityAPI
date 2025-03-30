using System.Collections.Generic;
using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Services.RouteGroup
{
    public class RouteGroupService : IRouteGroup
    {
        private readonly AppDbContext _context;

        public RouteGroupService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<List<Models.RouteGroup>>> GetAllRouteGroups()
        {

            ResponseModel<List<Models.RouteGroup>> response = new ResponseModel<List<Models.RouteGroup>>();

            try
            {
                var routegroup = await _context.RouteGroups.ToListAsync();

                if (routegroup == null)
                {
                    response.Message = "No route groups were found!";
                    return response;
                }
                response.Data = routegroup;
                response.Message = "All route groups were found!";
                return response;

            } catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
                
            
            }
        }
    }
}
