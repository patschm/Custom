using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepZeurver
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class BlaMiddleware
    {
        private readonly RequestDelegate _next;

        public BlaMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Incoming");
            await _next(httpContext);
            Console.WriteLine("Outgoing");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class BlaMiddlewareExtensions
    {
        public static IApplicationBuilder UseBlaMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BlaMiddleware>();
        }
    }
}
