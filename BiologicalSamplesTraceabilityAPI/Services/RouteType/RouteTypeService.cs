using System.Collections.Generic;
using Azure;
using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Services.RouteType
{
    public class RouteTypeService : IRouteType


    {
        private readonly AppDbContext _context;


        public RouteTypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<Models.RouteType>>> GetAllRouteTypes()
        {

            ResponseModel<List<Models.RouteType>> response = new ResponseModel<List<Models.RouteType>>();
            try
            {

                var routeType = await _context.RouteTypes.ToListAsync();

                response.Data = routeType;
                response.Message = "All route types was collected!";
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
