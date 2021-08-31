using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;
using SimpleUI2.DataAccess;

namespace SimpleUI2
{
    /// <summary>
    /// https://localhost:44342/
    /// </summary>
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddRefitClient<IGuestData>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new System.Uri("https://localhost:44342/api");//slash api because GuestController has attribute "api/[controller]"
            }
            );

            await builder.Build().RunAsync();
        }
    }
}
