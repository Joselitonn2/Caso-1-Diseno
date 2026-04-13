using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a DUA template upload session
    /// </summary>
    public class TemplateSession
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string TemplateFileName { get; set; }
        public string StorageUri { get; set; }
        public string Status { get; set; } // Active, Archived
        public List<string> MergeFields { get; set; } = new List<string>();
        public string CorrelationId { get; set; }
        public bool IsDefault { get; set; }
    }
}
