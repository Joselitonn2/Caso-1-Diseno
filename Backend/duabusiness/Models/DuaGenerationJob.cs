using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a DUA generation job with processing status and results
    /// </summary>
    public class DuaGenerationJob
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FileUploadSessionId { get; set; }
        public Guid TemplateSessionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string Status { get; set; } // Pending, Processing, Completed, Failed, ReviewRequired
        public string CorrelationId { get; set; }
        public string GeneratedDocumentUri { get; set; }
        public Guid? GeneratedDuaDataId { get; set; }
        public List<string> ValidationErrors { get; set; } = new List<string>();
        public List<string> ReviewFlags { get; set; } = new List<string>();
        public int ApproximatePercentCompletion { get; set; }
    }
}
