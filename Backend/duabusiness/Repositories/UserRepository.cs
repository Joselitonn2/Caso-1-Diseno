using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for User persistence
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByAzureAdIdAsync(string azureAdId);
        Task<List<User>> GetByRoleAsync(string role);
        Task<List<User>> GetActiveUsersAsync();
    }

    public class UserRepository : Repository<User>, IUserRepository
    {
        // TODO: Implement user specific queries

        public async Task<User> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByAzureAdIdAsync(string azureAdId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetByRoleAsync(string role)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetActiveUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}
