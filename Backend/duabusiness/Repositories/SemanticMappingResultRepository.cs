using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for SemanticMappingResult persistence
    /// </summary>
    public interface ISemanticMappingResultRepository : IRepository<SemanticMappingResult>
    {
        Task<SemanticMappingResult> GetByGenerationJobAsync(Guid jobId);
        Task<List<SemanticMappingResult>> GetByProcessingStatusAsync(string status);
    }

    public class SemanticMappingResultRepository : Repository<SemanticMappingResult>, ISemanticMappingResultRepository
    {
        // TODO: Implement semantic mapping result specific queries

        public async Task<SemanticMappingResult> GetByGenerationJobAsync(Guid jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SemanticMappingResult>> GetByProcessingStatusAsync(string status)
        {
            throw new NotImplementedException();
        }
    }
}
