using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for OCRExtractionResult persistence
    /// </summary>
    public interface IOCRExtractionResultRepository : IRepository<OCRExtractionResult>
    {
        Task<OCRExtractionResult> GetByFileMetadataAsync(Guid fileMetadataId);
        Task<List<OCRExtractionResult>> GetByProcessingStatusAsync(string status);
    }

    public class OCRExtractionResultRepository : Repository<OCRExtractionResult>, IOCRExtractionResultRepository
    {
        // TODO: Implement OCR extraction result specific queries

        public async Task<OCRExtractionResult> GetByFileMetadataAsync(Guid fileMetadataId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OCRExtractionResult>> GetByProcessingStatusAsync(string status)
        {
            throw new NotImplementedException();
        }
    }
}
