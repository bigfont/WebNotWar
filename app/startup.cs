using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;

namespace WebNotWar
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello from a minimal ASP.NET Core rc1 Web App.");
            });
        }

        public static void Main(string[] args) => WebApplication.Run(args);
    }
}
