using BiologicalSamplesTraceabilityAPI.Models;

namespace BiologicalSamplesTraceabilityAPI.Services.SampleType
{
    public interface ISampleType
    {

        Task<ResponseModel<List<Models.SampleType>>> GetAllSampleTypes();
    }
}
