using System;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Stores metadata information about uploaded files
    /// </summary>
    public class FileMetadata
    {
        public Guid Id { get; set; }
        public Guid FileUploadSessionId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; } // pdf, docx, xlsx, jpg, png, tiff, txt
        public long FileSizeBytes { get; set; }
        public string StorageUri { get; set; }
        public DateTime UploadedAt { get; set; }
        public Guid UploadedByUserId { get; set; }
        public string ProcessingStatus { get; set; } // Pending, Processing, Completed, Failed
        public string CorrelationId { get; set; } // For tracking
        public bool IsMalwareSafe { get; set; }
        public bool IsDuplicate { get; set; }
        public string ValidationError { get; set; }
    }
}
