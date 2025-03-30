using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.SampleType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiologicalSamplesTraceabilityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleTypeController : ControllerBase
    {
        private readonly ISampleType _sampleType;

        public SampleTypeController(ISampleType sampleType)
        {
            _sampleType = sampleType;
        }

        [HttpGet("GetAllRouteTypes")]
        public async Task<ActionResult<ResponseModel<List<SampleType>>>> GetAllSampleTypes()
        {
            var sampleTypes = await _sampleType.GetAllSampleTypes();
            return Ok(sampleTypes);
        }
    }
}
