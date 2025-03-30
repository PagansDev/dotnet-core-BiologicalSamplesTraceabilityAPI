using System.Collections.Generic;
using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Services.SampleBatch
{
    public class SampleBatchService : ISampleBatch
    {
        private readonly AppDbContext _context;

        public SampleBatchService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<Models.SampleBatch>>> GetAllSampleBatches()
        {
            ResponseModel<List<Models.SampleBatch>> response = new ResponseModel<List<Models.SampleBatch>>();

            try
            {
                var samplebatches = await _context.SampleBatches.ToListAsync();

                if (samplebatches == null)
                {
                    response.Message = "No Sample Batches were found!";
                    return response;
                }
                response.Data = samplebatches;
                response.Message = "";
                return response;
            }

            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;

            }
        }
    }
}
