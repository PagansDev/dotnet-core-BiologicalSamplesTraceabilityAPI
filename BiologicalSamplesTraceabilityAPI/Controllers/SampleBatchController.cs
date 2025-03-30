using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.SampleBatch;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiologicalSamplesTraceabilityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleBatchController : ControllerBase
    {
        private readonly ISampleBatch _sampleBatch;

        public SampleBatchController(ISampleBatch sampleBatch)
        {
            _sampleBatch = sampleBatch;
        }


        [HttpGet("GetAllSampleBatches")]
        public async Task<ActionResult<ResponseModel<List<SampleBatch>>>> GetAllSampleBatches()
        {
            var sampleBatch = await _sampleBatch.GetAllSampleBatches();
            return Ok(sampleBatch);
        }
    }
}
