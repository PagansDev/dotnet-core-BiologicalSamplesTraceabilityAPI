using BiologicalSamplesTraceability.API.Services.SampleBatch;
using BiologicalSamplesTraceability.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;

namespace BiologicalSamplesTraceability.API.Controllers.SampleBatch
{


    [Route("api/v1/[controller]")]
    [ApiController]
    public class SampleBatchController : ControllerBase
    {
        private readonly ISampleBatchInterface _sampleBatchInterface;

        public SampleBatchController(ISampleBatchInterface sampleBatchInterface)
        {
            _sampleBatchInterface = sampleBatchInterface;
        }


        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<ResponseModel<List<Core.Entities.SampleBatch>>>> GetAllAsync()
        {
            var samplebatches = await _sampleBatchInterface.GetAllAsync();
            return Ok(samplebatches);
        }

        [HttpGet("GetByIdAsync/{SampleBatchId}")]
        public async Task<ActionResult<ResponseModel<List<Core.Entities.SampleBatch>>>> GetByIdAsync(long SampleBatchId)
        {
            var samplebatch = await _sampleBatchInterface.GetByIdAsync(SampleBatchId);
            return Ok(samplebatch);
        }

        [HttpGet("GetByBatchIdentifierAsync/{BatchIdentifierCode}")]
        public async Task<ActionResult<ResponseModel<List<Core.Entities.SampleBatch>>>> GetByBatchIdentifierAsync(string BatchIdentifierCode)
        {
            var samplebatch = await _sampleBatchInterface.GetByBatchIdentifierAsync(BatchIdentifierCode);
            return Ok(samplebatch);
        }


    }
}
