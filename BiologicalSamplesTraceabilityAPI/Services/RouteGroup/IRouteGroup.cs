using BiologicalSamplesTraceabilityAPI.Models;

namespace BiologicalSamplesTraceabilityAPI.Services.RouteGroup
{
    public interface IRouteGroup
    {

        Task<ResponseModel<List<Models.RouteGroup>>> GetAllRouteGroups();
    }
}
