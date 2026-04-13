using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for DuaData persistence
    /// </summary>
    public interface IDuaDataRepository : IRepository<DuaData>
    {
        Task<DuaData> GetByGenerationJobAsync(Guid jobId);
        Task<List<DuaData>> GetByInvoiceNumberAsync(string invoiceNumber);
        Task<List<DuaData>> GetByCountryOfOriginAsync(string countryCode);
    }

    public class DuaDataRepository : Repository<DuaData>, IDuaDataRepository
    {
        // TODO: Implement DUA data specific queries

        public async Task<DuaData> GetByGenerationJobAsync(Guid jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DuaData>> GetByInvoiceNumberAsync(string invoiceNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DuaData>> GetByCountryOfOriginAsync(string countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
