using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a file upload session for a folder of documents
    /// </summary>
    public class FileUploadSession
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string Status { get; set; } // Active, Completed, Failed
        public string CorrelationId { get; set; }
        public int FileCount { get; set; }
        public long TotalSizeBytes { get; set; }
        public List<Guid> FileMetadataIds { get; set; } = new List<Guid>();
    }
}
