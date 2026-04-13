using System;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a notification message for async processing events
    /// </summary>
    public class NotificationMessage
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? DuaGenerationJobId { get; set; }
        public string EventType { get; set; } // ProcessingStarted, ProcessingCompleted, ProcessingFailed, ReviewRequired
        public string Message { get; set; }
        public string Status { get; set; } // Pending, Sent, Failed
        public DateTime CreatedAt { get; set; }
        public DateTime? SentAt { get; set; }
        public string CorrelationId { get; set; }
    }
}
