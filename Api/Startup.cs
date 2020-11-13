using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entidades.Servicos;
using Api.Infra;
using Api.Servicos;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Api
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
            services.AddControllers();

            services.Configure<Configuracoes>(Options =>
            {
                Options.ConnectionString = Configuration.GetSection("Connection:String").Value;
            });

            #region [Injeção de dependencia]
            services.AddTransient<ILivroService, LivroService>();
            #endregion

            #region [cors]
            services.AddCors();
            #endregion

            #region [Swagger]    
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Api Biblia Sagrada",
                    Version = "v1"
                });

            });
            #endregion

            #region [AutoMaper]            
            services.AddAutoMapper(typeof(Startup));
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region [Cors]
            app.UseCors(x =>
            {
                x.AllowAnyHeader();
                x.AllowAnyMethod();
                x.AllowAnyOrigin();
            });
            #endregion

            #region [Swagger]
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
#if DEBUG
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Biblia Sagrada");
#else
                  app.UseSwaggerUI(c => { c.SwaggerEndpoint("v1/swagger.json", "Receitas"); });
#endif
            });
            #endregion

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
