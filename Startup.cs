using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleDBContext;
using SimpleDBContext.Models;

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
            //https://stackoverflow.com/questions/58266344/net-core-3-mvc-using-usemvcwithdefaultroute-to-configure-mvc-is-not-suppo
            services.AddMvc(option => option.EnableEndpointRouting = false);

            var connection = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<IdentityDBContext>(config => config.UseSqlServer(connection));

            //AddIdentity 需要传递两个范型参数
            //UserStore 创建用户和验证其密码
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityDBContext>();
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

            //开始使用MVC 默认路由规则
            //app.UseMvcWithDefaultRoute();

            //插入 Identity 中间件的位置非常重要，如果在管道中插入中间件的时间太晚，它将永远没有机会处理请求
            //https://www.cnblogs.com/lonelyxmas/p/9724398.html
            app.UseAuthentication();

            app.UseMvc(ConfigureRoute);

            var msg = _configuration["msg"];
            app.Run(async context =>
            {
                //throw new System.Exception("Throw Exception..");
                context.Response.ContentType = "text/plain;charset=utf-8";
                await context.Response.WriteAsync($"<h1>:-)</h1>{msg}");
            });
        }

        public void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
