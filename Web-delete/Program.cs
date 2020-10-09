using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Services.Convertor;
using Web.Services.MonicaCharts;

namespace Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<Radzen.NotificationService>();

            // Added on 13:30 18.05.2020
            builder.Services.AddScoped<Services.IFileUpload, Services.FileUpload>();
            builder.Services.AddSingleton<Services.AppData>();  
            builder.Services.AddSingleton<Services.ZmqProducer>();
            builder.Services.AddSingleton<Services.ZmqConsumer>();
            builder.Services.AddTransient<Services.IMonicaZmqService, Services.MonicaParameters>();

            // My Services
            builder.Services.AddTransient<IMonicaJsonMapperService<string>, MonicaJsonToModelMapperService>();
            builder.Services.AddTransient<IMonicaChartService, MonicaChartService>();

            await builder.Build().RunAsync();
        }
    }
}
