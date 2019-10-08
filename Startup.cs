using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyASP.NetCoreDemo
{
        public class Startup
        {
                // This method gets called by the runtime. Use this method to add services to the container.
                // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
                public void ConfigureServices(IServiceCollection services)
                {

                        //mvc core 只包含核心的MVC的功能
                        //MVC 包含了依赖于MVC Core以及相关的第三方常用的服务和方法
                        services.AddMvc();

                }

                // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
                public void Configure(IApplicationBuilder app, IHostingEnvironment env)
                {
                        if (env.IsDevelopment())
                        {
                                app.UseDeveloperExceptionPage();
                        }

                        app.UseStaticFiles();

                        app.UseMvcWithDefaultRoute();

                        app.Run(async (context) =>
                        {
                                await context.Response.WriteAsync("Hello World!");
                        });
                }
        }
}
