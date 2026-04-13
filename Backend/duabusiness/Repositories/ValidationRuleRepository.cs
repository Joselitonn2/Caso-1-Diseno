using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for ValidationRule persistence
    /// </summary>
    public interface IValidationRuleRepository : IRepository<ValidationRule>
    {
        Task<List<ValidationRule>> GetActiveRulesAsync();
        Task<List<ValidationRule>> GetByRuleTypeAsync(string ruleType);
        Task<List<ValidationRule>> GetByPriorityAsync(int priority);
    }

    public class ValidationRuleRepository : Repository<ValidationRule>, IValidationRuleRepository
    {
        // TODO: Implement validation rule specific queries

        public async Task<List<ValidationRule>> GetActiveRulesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ValidationRule>> GetByRuleTypeAsync(string ruleType)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ValidationRule>> GetByPriorityAsync(int priority)
        {
            throw new NotImplementedException();
        }
    }
}
