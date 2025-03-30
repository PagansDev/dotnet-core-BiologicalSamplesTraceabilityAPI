using BiologicalSamplesTraceabilityAPI.Models;

namespace BiologicalSamplesTraceabilityAPI.Services.SampleBatch
{
    public interface ISampleBatch
    {

        Task<ResponseModel<List<Models.SampleBatch>>> GetAllSampleBatches();
    }
}
