using EasyTalentos.Dominio.Contratos;
using EasyTalentos.Repositorio.DataBase;
using EasyTalentos.Repositorio.UnityOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EasyTalentos.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });



            services.AddDbContext<EasyContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DbEasyConnection"))
                            .UseLazyLoadingProxies() //Usando carga preguiçosa para carregar o relacionamento na propriedade "virtual"
                            );

            services.AddScoped<IUnityOfWork, UnityOfWork>();

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            /*Utilizando o middleware Cors para permitir o acesso de outra url*/
            app.UseCors(x => x.SetIsOriginAllowed(l => l == @"http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());

            app.UseHttpsRedirection();


            app.UseStaticFiles();

            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
            });

            app.UseSpa(spa =>
            {

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                    //spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
