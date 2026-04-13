using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DuaBusiness.Models;

namespace DuaBusiness.Repositories
{
    /// <summary>
    /// Repository for FileMetadata persistence
    /// </summary>
    public interface IFileMetadataRepository : IRepository<FileMetadata>
    {
        Task<List<FileMetadata>> GetSessionFilesAsync(Guid sessionId);
        Task<FileMetadata> GetByFileNameAsync(string fileName);
        Task<List<FileMetadata>> GetDuplicateFilesAsync(string fileName);
        Task UpdateProcessingStatusAsync(Guid fileId, string status);
    }

    public class FileMetadataRepository : Repository<FileMetadata>, IFileMetadataRepository
    {
        // TODO: Implement file metadata specific queries

        public async Task<List<FileMetadata>> GetSessionFilesAsync(Guid sessionId)
        {
            throw new NotImplementedException();
        }

        public async Task<FileMetadata> GetByFileNameAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FileMetadata>> GetDuplicateFilesAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProcessingStatusAsync(Guid fileId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
