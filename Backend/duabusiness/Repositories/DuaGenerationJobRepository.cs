using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for DuaGenerationJob persistence
    /// </summary>
    public interface IDuaGenerationJobRepository : IRepository<DuaGenerationJob>
    {
        Task<List<DuaGenerationJob>> GetUserJobsAsync(Guid userId);
        Task<List<DuaGenerationJob>> GetJobsByStatusAsync(string status);
        Task<List<DuaGenerationJob>> GetFailedJobsAsync();
        Task<DuaGenerationJob> GetLastJobForUserAsync(Guid userId);
        Task UpdateJobStatusAsync(Guid jobId, string status);
        Task UpdateJobProgressAsync(Guid jobId, int percentCompletion);
    }

    public class DuaGenerationJobRepository : Repository<DuaGenerationJob>, IDuaGenerationJobRepository
    {
        // TODO: Implement DUA generation job specific queries

        public async Task<List<DuaGenerationJob>> GetUserJobsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DuaGenerationJob>> GetJobsByStatusAsync(string status)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DuaGenerationJob>> GetFailedJobsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DuaGenerationJob> GetLastJobForUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateJobStatusAsync(Guid jobId, string status)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateJobProgressAsync(Guid jobId, int percentCompletion)
        {
            throw new NotImplementedException();
        }
    }
}
