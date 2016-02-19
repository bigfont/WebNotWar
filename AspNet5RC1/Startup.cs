using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;

namespace AspNet5RC1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env) { }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("head, body");
            });
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
