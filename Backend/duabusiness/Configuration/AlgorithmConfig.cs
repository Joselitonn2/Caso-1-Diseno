using System;
using System.Collections.Generic;

namespace DuaBusiness.Configuration
{
    /// <summary>
    /// Business logic algorithms and parameters
    /// Configures AI/ML algorithm thresholds and parameters
    /// </summary>
    public class AlgorithmConfig
    {
        // Document Classification Algorithm
        public const double DocumentClassificationConfidenceThreshold = 0.75;
        public const int DocumentMinimumTextLength = 50;
        public const bool OcrFallbackEnabled = true;
        
        // OCR Extraction Algorithm
        public const string OcrLanguageModel = "en";
        public const int ScannedImageResolutionThreshold = 100; // DPI
        public const double OcrConfidenceThreshold = 0.70;
        
        // Semantic Mapping Algorithm
        public const double EntityConfidenceThreshold = 0.65;
        public const double FuzzyMatchTolerance = 0.80;
        
        // Validation Rules Engine
        public const double RequiredFieldConfidenceThreshold = 0.80;
        public const double CrossFieldConsistencyThreshold = 0.75;
        
        // Customs Terminology
        public static readonly Dictionary<string, string> CustomsTerminologySynonyms = new Dictionary<string, string>
        {
            { "FOB", "Free on Board" },
            { "CIF", "Cost, Insurance and Freight" },
            { "incoterm", "International Commercial Term" },
            { "tariff", "customs duty" },
            { "regime", "customs regime" }
        };
    }
}
