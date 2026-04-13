# DUA Business Backend

## Overview
DUA (Declaración Única Aduanal) Streamliner Backend API built with ASP.NET Core, designed to process and validate customs declaration documents.

## Project Structure

### [Controllers/](Controllers/)
REST API endpoints for:
- [FileUploadController](Controllers/FileUploadController.cs): File ingestion and management
- [TemplateController](Controllers/TemplateController.cs): DUA template management
- [DuaGenerationController](Controllers/DuaGenerationController.cs): Document generation orchestration
- [DuaDocumentController](Controllers/DuaDocumentController.cs): Preview and download operations
- [UserManagementController](Controllers/UserManagementController.cs): User CRUD operations (Manager only)
- [ReportController](Controllers/ReportController.cs): Analytics and reporting (Manager only)
- [AuthenticationController](Controllers/AuthenticationController.cs): Session and token management

### [Services/](Services/)
Business logic layer:
- [FileUploadService](Services/FileUploadService.cs): File handling and validation
- [TemplateService](Services/TemplateService.cs): Template processing
- [DuaGenerationService](Services/DuaGenerationService.cs): Generation orchestration
- [DuaDocumentService](Services/DuaDocumentService.cs): Document rendering
- [ValidationService](Services/ValidationService.cs): Data validation
- [NotificationService](Services/NotificationService.cs): Event notifications
- [AuditService](Services/AuditService.cs): Audit logging
- [UserManagementService](Services/UserManagementService.cs): User operations
- [ReportService](Services/ReportService.cs): Analytics
- [AuthenticationService](Services/AuthenticationService.cs): Auth handling

### [Models/](Models/)
Data entities:
- [User](Models/User.cs), [FileMetadata](Models/FileMetadata.cs), [FileUploadSession](Models/FileUploadSession.cs), [TemplateSession](Models/TemplateSession.cs)
- [DuaGenerationJob](Models/DuaGenerationJob.cs), [DuaData](Models/DuaData.cs), [AuditLog](Models/AuditLog.cs)
- [ValidationRule](Models/ValidationRule.cs), [OCRExtractionResult](Models/OCRExtractionResult.cs), [SemanticMappingResult](Models/SemanticMappingResult.cs)
- [NotificationMessage](Models/NotificationMessage.cs)

### [Repositories/](Repositories/)
Data access layer with Entity Framework Core:
- [IRepository](Repositories/IRepository.cs): Generic Repository pattern
- [FileUploadSessionRepository](Repositories/FileUploadSessionRepository.cs), [FileMetadataRepository](Repositories/FileMetadataRepository.cs)
- [TemplateSessionRepository](Repositories/TemplateSessionRepository.cs), [DuaGenerationJobRepository](Repositories/DuaGenerationJobRepository.cs)
- [DuaDataRepository](Repositories/DuaDataRepository.cs), [UserRepository](Repositories/UserRepository.cs)
- [AuditLogRepository](Repositories/AuditLogRepository.cs), [ValidationRuleRepository](Repositories/ValidationRuleRepository.cs)
- [OCRExtractionResultRepository](Repositories/OCRExtractionResultRepository.cs), [SemanticMappingResultRepository](Repositories/SemanticMappingResultRepository.cs)
- [NotificationMessageRepository](Repositories/NotificationMessageRepository.cs)

### [ApiClients/](ApiClients/)
External service integrations:
- [AzureBlobStorageClient](ApiClients/AzureBlobStorageClient.cs): File storage
- [AzureOcrClient](ApiClients/AzureOcrClient.cs): OCR processing
- [AzureNotificationHubsClient](ApiClients/AzureNotificationHubsClient.cs): Push notifications
- [AzureKeyVaultClient](ApiClients/AzureKeyVaultClient.cs): Secrets management
- [AzureApplicationInsightsClient](ApiClients/AzureApplicationInsightsClient.cs): Telemetry
- [DocumentProcessingClient](ApiClients/DocumentProcessingClient.cs): Document parsing
- [MalwareScanClient](ApiClients/MalwareScanClient.cs): Security scanning

### [Agents/](Agents/)
Processing orchestration (Agent pattern):
- [FileIngestionAgent](Agents/FileIngestionAgent.cs): File validation and ingestion
- [OCRProcessingAgent](Agents/OCRProcessingAgent.cs): Scanned document processing
- [SemanticInterpretationAgent](Agents/SemanticInterpretationAgent.cs): Field mapping
- [DuaGenerationAgent](Agents/DuaGenerationAgent.cs): Document generation
- [ValidationAgent](Agents/ValidationAgent.cs): Data validation
- [NotificationAgent](Agents/NotificationAgent.cs): Event notifications

### [Middleware/](Middleware/)
Cross-cutting concerns:
- [AuthenticationMiddleware](Middleware/AuthenticationMiddleware.cs): Token validation
- [AuthorizationMiddleware](Middleware/AuthorizationMiddleware.cs): Permission checking
- [RateLimitingMiddleware](Middleware/RateLimitingMiddleware.cs): Request throttling (60 req/min)
- [RequestSizeLimitMiddleware](Middleware/RequestSizeLimitMiddleware.cs): Payload limit (2 MiB)
- [ExceptionHandlingMiddleware](Middleware/ExceptionHandlingMiddleware.cs): Error handling
- [LoggingMiddleware](Middleware/LoggingMiddleware.cs): Request/response logging
- [HttpsEnforcementMiddleware](Middleware/HttpsEnforcementMiddleware.cs): HTTPS only
- [CorsMiddleware](Middleware/CorsMiddleware.cs): CORS policy

### [Validators/](Validators/)
Input validation:
- [FileValidator](Validators/FileValidator.cs): File type and size validation
- [TemplateValidator](Validators/TemplateValidator.cs): Template format validation
- [DuaDataValidator](Validators/DuaDataValidator.cs): DUA data consistency
- [UserInputValidator](Validators/UserInputValidator.cs): User input validation

### [Configuration/](Configuration/)
System configuration and policies:
- [SystemPolicies](Configuration/SystemPolicies.cs): Constants and limits
- [RolePermissionMap](Configuration/RolePermissionMap.cs): Permission matrix
- [AzureResourceConfig](Configuration/AzureResourceConfig.cs): Azure resource settings
- [AlgorithmConfig](Configuration/AlgorithmConfig.cs): AI/ML parameters
- [ApplicationSettings](Configuration/ApplicationSettings.cs): Environment config
- [ServiceRegistration](Configuration/ServiceRegistration.cs): Dependency injection
- [DatabaseConfig](Configuration/DatabaseConfig.cs): Database configuration

### [Exceptions/](Exceptions/)
Custom exception hierarchy:
- [DuaBusinessException](Exceptions/DuaBusinessException.cs): Base exception and specialized exceptions
  - AuthenticationException, AuthorizationException
  - FileUploadException, ValidationException
  - ProcessingException, ResourceNotFoundException

### [Logs/](Logs/)
Logging service:
- [LoggingService](Logs/LoggingService.cs): Application Insights integration

### [Utils/](Utils/)
Utility functions and extensions:
- [UtilityHelpers](Utils/UtilityHelpers.cs): String, Collection, DateTime extensions, Crypto and File utilities