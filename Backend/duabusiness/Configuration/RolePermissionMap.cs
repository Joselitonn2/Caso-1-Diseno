using System;
using System.Collections.Generic;

namespace DuaBusiness.Configuration
{
    /// <summary>
    /// Role-based permission mappings
    /// Defines permissions for each user role
    /// </summary>
    public class RolePermissionMap
    {
        public static readonly Dictionary<string, List<string>> RolePermissions = new Dictionary<string, List<string>>
        {
            {
                "Manager", new List<string>
                {
                    "MANAGE_USERS",      // Manage users with CRUD operations
                    "VIEW_REPORTS",      // Access operational and performance reports
                    "VIEW_LOGA"          // Access process logs and reports
                }
            },
            {
                "CustomsAgent", new List<string>
                {
                    "LOAD_FILE_FOLDER",  // Set and upload a folder with data files
                    "LOAD_TEMPLATE",     // Set and upload a file for the DUA template
                    "GENERATE_DUA",      // Start the AI process of generating a DUA
                    "PREVIEW_DUA",       // Show a preview of the generated DUA
                    "DOWNLOAD_DUA"       // Download the generated DUA
                }
            }
        };

        public static bool HasPermission(string role, string permissionCode)
        {
            return RolePermissions.ContainsKey(role) && 
                   RolePermissions[role].Contains(permissionCode);
        }

        public static List<string> GetPermissionsForRole(string role)
        {
            return RolePermissions.ContainsKey(role) ? RolePermissions[role] : new List<string>();
        }
    }
}
