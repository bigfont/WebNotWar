namespace Algae.WebApp
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("head, body");
            });
        }
    }
}
