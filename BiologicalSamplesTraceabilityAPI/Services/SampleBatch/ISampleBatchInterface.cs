using BiologicalSamplesTraceability.Core.Entities;

namespace BiologicalSamplesTraceability.API.Services.SampleBatch
{
    public interface ISampleBatchInterface
    {
        Task<ResponseModel<List<BiologicalSamplesTraceability.Core.Entities.SampleBatch>>> GetAllAsync();
        Task<ResponseModel<BiologicalSamplesTraceability.Core.Entities.SampleBatch>> GetByIdAsync(long SampleBatchId);
        Task<ResponseModel<BiologicalSamplesTraceability.Core.Entities.SampleBatch>> GetByBatchIdentifierAsync(string BatchIdentifierCode);
    }
}
