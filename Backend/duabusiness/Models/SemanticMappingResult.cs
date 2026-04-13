using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents semantic mapping between extracted fields and DUA schema
    /// </summary>
    public class SemanticMappingResult
    {
        public Guid Id { get; set; }
        public Guid DuaGenerationJobId { get; set; }
        public DateTime MappedAt { get; set; }
        public Dictionary<string, object> MappedFields { get; set; } = new Dictionary<string, object>();
        public Dictionary<string, double> MappingConfidenceScores { get; set; } = new Dictionary<string, double>();
        public List<string> UnmappedFields { get; set; } = new List<string>();
        public List<string> TerminologyMatches { get; set; } = new List<string>();
        public string ProcessingStatus { get; set; } // Completed, PartialMatch, NoMatch
    }
}
