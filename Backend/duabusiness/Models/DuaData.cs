using System;
using System.Collections.Generic;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents extracted and processed DUA document data
    /// </summary>
    public class DuaData
    {
        public Guid Id { get; set; }
        public Guid DuaGenerationJobId { get; set; }
        public DateTime ExtractedAt { get; set; }
        
        // Importer/Exporter Information
        public string ImporterName { get; set; }
        public string ImporterTaxId { get; set; }
        public string ExporterName { get; set; }
        public string ExporterTaxId { get; set; }
        
        // Invoice Information
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceCurrency { get; set; }
        
        // Shipping Information
        public string Incoterms { get; set; }
        public decimal FobValue { get; set; }
        public decimal CifValue { get; set; }
        public string CountryOfOrigin { get; set; }
        
        // Product Information
        public string TariffDescription { get; set; }
        public string TariffCode { get; set; }
        public string CustomsRegime { get; set; }
        
        // Confidence Scores
        public Dictionary<string, double> FieldConfidenceScores { get; set; } = new Dictionary<string, double>();
        
        // Additional Metadata
        public List<string> RequiredFieldsPresent { get; set; } = new List<string>();
        public List<string> RequiredFieldsMissing { get; set; } = new List<string>();
    }
}
