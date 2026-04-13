using System;
using System.Collections.Generic;

namespace DuaBusiness.Configuration
{
    /// <summary>
    /// System policies and constraints
    /// Defines operational policies and limits
    /// </summary>
    public class SystemPolicies
    {
        // Authentication & Authorization Policies
        public const string AuthenticationProvider = "AzureEntraId";
        public const string MfaMethod = "MobileAuthenticatorApp";
        public static readonly List<string> ValidRoles = new List<string> { "Manager", "CustomsAgent" };
        
        // Rate Limiting Policies
        public const int RequestsPerMinutePerUser = 60;
        public const int MaxSimultaneousConnections = 20;
        
        // Request Size Policies
        public const long MaxRequestSizeBytes = 2 * 1024 * 1024; // 2 MiB
        
        // File Upload Policies
        public static readonly List<string> AllowedFileTypes = new List<string> 
        { 
            ".pdf", ".docx", ".xlsx", ".jpg", ".jpeg", ".png", ".tiff", ".txt" 
        };
        public const long MaxFileSizeBytes = 50 * 1024 * 1024; // 50 MB per file
        
        // Data Retention Policies
        public const int ArchiveDataAfterDays = 180;
        
        // API Response Timeouts
        public const int ApiTimeoutSeconds = 30;
        
        // Encryption Policies
        public const string DatabaseEncryption = "AES-256";
        
        // Transport Security
        public const bool HttpsOnly = true;
        
        // Environment Profiles
        public static readonly List<string> EnvironmentProfiles = new List<string> 
        { 
            "development", "staging", "production" 
        };
    }
}
