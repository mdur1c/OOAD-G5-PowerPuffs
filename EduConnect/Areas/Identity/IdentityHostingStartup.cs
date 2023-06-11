using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(EduConnect.Areas.Identity.IdentityHostingStartup))]
namespace EduConnect.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}