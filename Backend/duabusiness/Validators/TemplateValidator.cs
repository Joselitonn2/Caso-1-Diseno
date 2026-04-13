using System;
using DuaBusiness.Models;

namespace DuaBusiness.Validators
{
    /// <summary>
    /// Validator for DUA template files
    /// Validates Word template format and merge fields
    /// </summary>
    public interface ITemplateValidator
    {
        ValidationResult ValidateTemplate(string fileName, byte[] fileContent);
        ValidationResult ValidateMergeFields(TemplateSession template);
    }

    public class TemplateValidator : ITemplateValidator
    {
        // TODO: Implement template validation
        // - Validate Word format (.docx)
        // - Extract and validate merge fields
        // - Check for required DUA fields
        // - Ensure template structure

        public ValidationResult ValidateTemplate(string fileName, byte[] fileContent)
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidateMergeFields(TemplateSession template)
        {
            throw new NotImplementedException();
        }
    }
}
