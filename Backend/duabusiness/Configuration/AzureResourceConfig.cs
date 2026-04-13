using System;

namespace DuaBusiness.Configuration
{
    /// <summary>
    /// Azure resource allocation and scaling configuration
    /// Defines initial resource allocation and scaling rules
    /// </summary>
    public class AzureResourceConfig
    {
        // Azure API Management (APIM)
        public const string ApimTier = "Standard";
        public const int ApimInitialScaleUnits = 1;
        public const double ApimCpuThresholdPercent = 70;
        public const int ApimRequestQueueThreshold = 500;
        public const int ApimTimeoutSeconds = 30;
        
        // Azure App Service
        public const string AppServicePlan = "Standard_S2";
        public const int AppServiceVCpuCount = 2;
        public const int AppServiceMemoryGb = 4;
        public const double AppServiceCpuScaleOutThreshold = 70;
        public const int AppServiceCpuScaleOutDurationMinutes = 5;
        public const double AppServiceCpuScaleInThreshold = 30;
        public const int AppServiceCpuScaleInDurationMinutes = 10;
        public const int AppServiceMaxInstances = 5;
        public const int AppServiceMinInstances = 1;
        
        // Azure Blob Storage
        public const string BlobStorageTier = "Hot";
        public const string BlobArchiveTier = "Cool";
        public const bool BlobVersioningEnabled = true;
        
        // Azure SQL Database
        public const bool DatabaseEncryptionEnabled = true;
        public const bool DatabaseAutoBackupEnabled = true;
        public const bool DatabaseGeoRedundantBackup = true;
        
        // Networking
        public const string HttpsPort = "443";
        public const bool VnetIntegrationEnabled = false;
        public const bool PrivateEndpointForKeyVault = true;
    }
}
