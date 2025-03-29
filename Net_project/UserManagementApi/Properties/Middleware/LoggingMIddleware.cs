using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace UserManagementApi.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Handling request: {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"Finished handling request: {context.Response.StatusCode}");
        }
    }
}
