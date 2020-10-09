using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using blzCapnp.Services;
using Application.Convertor;
using Application.MonicaCharts;
using blzCapnp.Services.MonicaCharts;
using blzCapnp.Services.Github;
using Microsoft.JSInterop;
using Blazored.LocalStorage;
using Radzen;

namespace blzCapnp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddScoped<IFileUpload, FileUpload>();
            
            services.AddSingleton<Services.FileFolders.MonicaParametersFolder>();  //added to test file and folder
            services.AddTransient<IMonicaZmqService, MonicaParameters>();

            // My Services
            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();

            services.AddBlazoredLocalStorage();

            services.AddScoped<Radzen.NotificationService>();
            services.AddTransient<IMonicaJsonMapper, MonicaJsonMapper>();
            services.AddTransient<IMonicaChartApp, MonicaChartApp>();
            services.AddTransient<IMonicaChartService, MonicaChartService>();
            services.AddTransient<IGithubService, GithubService>();
            services.AddTransient<MonicaIO>();
            services.AddTransient<ZmqProducer>();
            services.AddTransient<ZmqConsumer>();
            services.AddTransient<CapnpWeather>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
