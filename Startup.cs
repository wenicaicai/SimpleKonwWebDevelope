using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SimpleKonwWebDevelope
{
    public class Startup
    {
        public IConfiguration _configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //服务的配置
        //EF MVC Identity
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //用于定义HTTP请求管道的中间件
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //起到引导报错信息展示的作用
            //若注释，则会隐藏报错
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseWelcomePage();

            //app.UseDefaultFiles();
            //app.UseStaticFiles(); 

            app.UseFileServer();//等价于上面两行代码
            
            //var msg = _configuration["msg"];
            //app.Run(async context => 
            //{
            //    //throw new System.Exception("Throw Exception..");
            //    context.Response.ContentType = "text/plain;charset=utf-8";
            //    await context.Response.WriteAsync($"<h1>:-)</h1>{msg}"); 
            //});
        }
    }
}
