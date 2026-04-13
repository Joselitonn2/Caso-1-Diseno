using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents OCR extraction results from scanned documents
    /// </summary>
    public class OCRExtractionResult
    {
        public Guid Id { get; set; }
        public Guid FileMetadataId { get; set; }
        public DateTime ExtractedAt { get; set; }
        public string RawText { get; set; }
        public Dictionary<string, string> ExtractedEntities { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, double> EntityConfidenceScores { get; set; } = new Dictionary<string, double>();
        public string ProcessingStatus { get; set; } // Completed, Failed, PartialMatch
        public string ProcessingError { get; set; }
        public double AverageConfidence { get; set; }
    }
}
