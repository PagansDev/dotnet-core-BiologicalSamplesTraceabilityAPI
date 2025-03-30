using System.Collections.Generic;
using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Services.SampleType
{
    public class SampleTypeService : ISampleType
    {
        private readonly AppDbContext _context;

        public SampleTypeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<List<Models.SampleType>>> GetAllSampleTypes()
        {
            ResponseModel<List<Models.SampleType>> response = new ResponseModel<List<Models.SampleType>>();

            try
            {
                var sampleTypes = await _context.SampleTypes.ToListAsync();

                if (sampleTypes == null)
                {
                    response.Message = "no Sample Types were found!";
                    return response;
                }

                response.Data = sampleTypes;
                response.Message = "All Sample Types were found!";
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
