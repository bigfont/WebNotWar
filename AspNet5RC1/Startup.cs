using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNet5RC1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env) { }

        public IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services) { }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("head, body");
            });
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
