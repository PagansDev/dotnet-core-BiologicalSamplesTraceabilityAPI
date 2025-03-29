using BiologicalSamplesTraceabilityAPI.Models;

namespace BiologicalSamplesTraceabilityAPI.Services.RouteType
{
    public interface IRouteType
    {


        Task<ResponseModel<List<Models.RouteType>>> GetAllRouteTypes();



    }
}
