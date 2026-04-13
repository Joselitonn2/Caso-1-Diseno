using System;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a validation rule for DUA data consistency checks
    /// </summary>
    public class ValidationRule
    {
        public Guid Id { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; } // RequiredField, FormatValidation, CrossFieldConsistency, DuplicateInvoice, ConfidenceThreshold
        public string Description { get; set; }
        public string RelatedFields { get; set; }
        public double ConfidenceThreshold { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
