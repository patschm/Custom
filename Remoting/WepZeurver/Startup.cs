using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepZeurver.Services;

namespace WepZeurver
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region snippet1
            //var physicalProvider = _env.ContentRootFileProvider;
            //var manifestEmbeddedProvider =
            //    new ManifestEmbeddedFileProvider(typeof(Program).Assembly);
            //var compositeProvider =
            //    new CompositeFileProvider(physicalProvider, manifestEmbeddedProvider);

            //services.AddSingleton<IFileProvider>(compositeProvider);
            #endregion

            services.AddSignalR();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {           
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ZeurService>("/zeur");
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
