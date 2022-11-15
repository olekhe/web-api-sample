using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Minimized.Core.Abstractions;
using WebApi.Minimized.Dal.DataContext;
using WebApi.Minimized.Gateway.Models;

namespace WebApi.Minimized.Gateway
{
    public class Startup
    {
        public Settings Settings { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var settings = new Settings();
            configuration.Bind(settings);
            Settings = settings;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<JohnyDavDataAccess>(options =>
              options.UseSqlServer(Settings.ConnectionString));

            services.AddScoped<IGenericRepository, DataAccessContextRepository>();
            
            services.AddControllers()
                    .AddNewtonsoftJson(options => options
                                                        .SerializerSettings
                                                        .ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
