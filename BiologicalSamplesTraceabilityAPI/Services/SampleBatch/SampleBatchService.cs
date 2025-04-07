using Azure;
using BiologicalSamplesTraceability.Api.Data;
using BiologicalSamplesTraceability.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceability.API.Services.SampleBatch
{
    public class SampleBatchService : ISampleBatchInterface
    {
        private readonly AppDbContext _context;

        public SampleBatchService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<Core.Entities.SampleBatch>>> GetAllAsync()
        {
            ResponseModel<List<Core.Entities.SampleBatch>> response = new ResponseModel<List<Core.Entities.SampleBatch>>();

            try
            {

                var samplebatches = await _context.SampleBatches.ToListAsync();
              
                response.Data = samplebatches;
                response.Message = "All sample batches were found!";
                return response;

            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
                response.Status = false;
                return response;
            
            }

        }

        public async Task<ResponseModel<Core.Entities.SampleBatch>> GetByBatchIdentifierAsync(string BatchIdentifierCode)
        {

            ResponseModel<Core.Entities.SampleBatch> response = new ResponseModel<Core.Entities.SampleBatch>();

            try
            {
                var batchIdentifier = await _context.BatchIdentifiers
                    .Include(bi => bi.SampleBatch)
                    .FirstOrDefaultAsync(bi => bi.Code == BatchIdentifierCode);   

                if (batchIdentifier == null)
                {
                    response.Message = "No Sample Batch was found!";
                    return response;
                }

                response.Data = batchIdentifier.SampleBatch;
                response.Message = "The Sample Batch was found!";
                return response;


            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
                response.Status = false;
                return response;

            }
        }

        public async Task<ResponseModel<Core.Entities.SampleBatch>> GetByIdAsync(long SampleBatchId)
        {

            ResponseModel<Core.Entities.SampleBatch> response = new ResponseModel<Core.Entities.SampleBatch>();

            try
            {
                var sampleBatch = await _context.SampleBatches.FirstOrDefaultAsync(sb => sb.Id == SampleBatchId);

                if (sampleBatch == null)
                {
                    response.Message = "No Sample Batch was found!";
                    return response;
                }

                response.Data = sampleBatch;
                response.Message = "The Sample Batch was found!";
                return response;


            }
            catch (Exception ex)
            {

                response.Message = ex.Message;
                response.Status = false;
                return response;

            }
        }
    }
}
