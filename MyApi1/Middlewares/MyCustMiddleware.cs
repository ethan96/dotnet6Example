using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi1.Middlewares
{
    public class MyCustMiddleware
    {
        RequestDelegate _next;
        public MyCustMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Use my cust middleware start." + Environment.NewLine);
            await _next.Invoke(context);
            await context.Response.WriteAsync("Use my cust middleware end." + Environment.NewLine);
        }
    }

    public static class MyCustMiddlewareExtention
    {
        public static void UseCustom(this IApplicationBuilder app)
        {
            app.UseMiddleware<MyCustMiddleware>();
        }
    }
}