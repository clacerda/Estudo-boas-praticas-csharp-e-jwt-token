using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Projeto.LeilaoOnline.WebApp.Dados;
using Projeto.LeilaoOnline.WebApp.Dados.EfCore;
using Projeto.LeilaoOnline.WebApp.Services;
using Projeto.LeilaoOnline.WebApp.Services.Handlers;

namespace Projeto.LeilaoOnline.WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoriaDao, CategoriaDaoComEfCore>();
            services.AddTransient<ILeilaoDao, LeilaoDaoComEfCore>();
            services.AddTransient<IAdminService, ArquivamentoAdminService>();
            services.AddTransient<IProdutoService, DefaultProdutoService>();
            services.AddDbContext<AppDbContext>();
            services
                .AddControllersWithViews()
                .AddNewtonsoftJson(options => 
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePagesWithRedirects("/Home/StatusCode/{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
