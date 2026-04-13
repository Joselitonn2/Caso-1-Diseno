using System;

namespace DuaBusiness.Models
{
    /// <summary>
    /// Represents a user in the system with role-based access control
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Role { get; set; } // Manager or CustomsAgent
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string AzureAdId { get; set; } // Azure Entra ID identifier
    }
}
