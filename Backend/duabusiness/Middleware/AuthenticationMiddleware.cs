using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DuaBusiness.Middleware
{
    /// <summary>
    /// Middleware for authentication validation
    /// Validates Azure Entra ID tokens and session authorization
    /// </summary>
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // TODO: Implement authentication middleware
        // - Extract token from Authorization header
        // - Validate Azure Entra ID token
        // - Check token expiration
        // - Attach user claims to HttpContext
        // - Return 401 Unauthorized if invalid

        public async Task InvokeAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
