using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RallyDakar.Dominio.DbContexto;
using RallyDakar.Dominio.Interfaces;
using RallyDakar.Dominio.Repositorios;

namespace RallyDakar.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RallyDbContexto>(opt => opt.UseInMemoryDatabase("RallyDB"),
                ServiceLifetime.Scoped,
                ServiceLifetime.Scoped);

            services.AddControllers()
                    .AddNewtonsoftJson();                    
            
            services.AddScoped<IPilotoRepositorio, PilotoRepositorio>();
            services.AddScoped<ITelemetriaRepositorio, TelemetriaRepositorio>();
            services.AddScoped<IEquipeRepositorio, EquipeRepositorio>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
