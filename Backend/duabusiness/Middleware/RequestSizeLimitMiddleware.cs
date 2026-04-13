using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DuaBusiness.Middleware
{
    /// <summary>
    /// Middleware for request payload size limiting
    /// Policy: max 2 MiB per request
    /// </summary>
    public class RequestSizeLimitMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly long _maxRequestSize = 2 * 1024 * 1024; // 2 MiB

        public RequestSizeLimitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        // TODO: Implement request size limit middleware
        // - Check Content-Length header
        // - max 2 MiB per request
        // - Return 413 Payload Too Large if exceeded
        // - Apply only to file upload endpoints

        public async Task InvokeAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
