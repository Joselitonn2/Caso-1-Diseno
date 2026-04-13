using System;
using System.Collections.Generic;
using System.Linq;

namespace DuaBusiness.Validators
{
    /// <summary>
    /// Base validator interface for fluent validation
    /// </summary>
    public interface IValidator<T>
    {
        ValidationResult Validate(T model);
    }

    /// <summary>
    /// Result of validation operation
    /// </summary>
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
