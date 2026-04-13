using System;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents audit logs for tracking user actions and system events
    /// </summary>
    public class AuditLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime EventTime { get; set; }
        public string EventType { get; set; } // Login, Logout, FileUpload, TemplateLoad, DuaGeneration, DuaDownload
        public string EntityType { get; set; } // User, File, Template, DuaJob
        public Guid? EntityId { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Status { get; set; } // Success, Failed
        public string CorrelationId { get; set; }
    }
}
