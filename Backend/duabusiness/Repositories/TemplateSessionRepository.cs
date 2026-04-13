using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for TemplateSession persistence
    /// </summary>
    public interface ITemplateSessionRepository : IRepository<TemplateSession>
    {
        Task<List<TemplateSession>> GetUserTemplatesAsync(Guid userId);
        Task<TemplateSession> GetDefaultTemplateAsync(Guid userId);
        Task<TemplateSession> GetActiveTemplateAsync(Guid userId);
        Task SetDefaultTemplateAsync(Guid templateId);
    }

    public class TemplateSessionRepository : Repository<TemplateSession>, ITemplateSessionRepository
    {
        // TODO: Implement template session specific queries

        public async Task<List<TemplateSession>> GetUserTemplatesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<TemplateSession> GetDefaultTemplateAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<TemplateSession> GetActiveTemplateAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task SetDefaultTemplateAsync(Guid templateId)
        {
            throw new NotImplementedException();
        }
    }
}
