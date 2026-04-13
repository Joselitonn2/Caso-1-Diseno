using System;

namespace DuaBusiness.Exceptions
{
    /// <summary>
    /// Base exception class for DUA Business operations
    /// Implements Singleton pattern for centralized exception handling
    /// </summary>
    public class DuaBusinessException : Exception
    {
        public string ErrorCode { get; set; }
        public string CorrelationId { get; set; }

        public DuaBusinessException(string message, string errorCode, string correlationId = null)
            : base(message)
        {
            ErrorCode = errorCode;
            CorrelationId = correlationId ?? Guid.NewGuid().ToString();
        }
    }

    public class AuthenticationException : DuaBusinessException
    {
        public AuthenticationException(string message, string correlationId = null)
            : base(message, "AUTH_001", correlationId) { }
    }

    public class AuthorizationException : DuaBusinessException
    {
        public AuthorizationException(string message, string correlationId = null)
            : base(message, "AUTHZ_001", correlationId) { }
    }

    public class FileUploadException : DuaBusinessException
    {
        public FileUploadException(string message, string correlationId = null)
            : base(message, "FILE_001", correlationId) { }
    }

    public class ValidationException : DuaBusinessException
    {
        public ValidationException(string message, string correlationId = null)
            : base(message, "VAL_001", correlationId) { }
    }

    public class ProcessingException : DuaBusinessException
    {
        public ProcessingException(string message, string correlationId = null)
            : base(message, "PROC_001", correlationId) { }
    }

    public class ResourceNotFoundException : DuaBusinessException
    {
        public ResourceNotFoundException(string message, string correlationId = null)
            : base(message, "NOT_FOUND_404", correlationId) { }
    }

    public class ConflictException : DuaBusinessException
    {
        public ConflictException(string message, string correlationId = null)
            : base(message, "CONFLICT_409", correlationId) { }
    }
}
