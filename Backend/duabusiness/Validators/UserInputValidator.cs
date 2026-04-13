using System;
using DuaBusiness.Models;

namespace DuaBusiness.Validators
{
    /// <summary>
    /// Validator for user input and requests
    /// Validates user-provided data in API requests
    /// </summary>
    public interface IUserInputValidator
    {
        ValidationResult ValidateEmail(string email);
        ValidationResult ValidateUserRole(string role);
        ValidationResult ValidatePermissionCode(string permissionCode);
    }

    public class UserInputValidator : IUserInputValidator
    {
        // TODO: Implement user input validation
        // - Email format validation
        // - Role validation (Manager, CustomsAgent)
        // - Permission code validation
        // - String length validation
        // - Special character validation

        public ValidationResult ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidateUserRole(string role)
        {
            throw new NotImplementedException();
        }

        public ValidationResult ValidatePermissionCode(string permissionCode)
        {
            throw new NotImplementedException();
        }
    }
}
