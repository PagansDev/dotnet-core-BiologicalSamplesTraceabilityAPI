using BiologicalSamplesTraceabilityAPI.Models;

namespace BiologicalSamplesTraceabilityAPI.Services.Routes
{
    public interface IRoute
    {

        Task<ResponseModel<List<Models.Route>>> GetAllRoutes();
    }
}
