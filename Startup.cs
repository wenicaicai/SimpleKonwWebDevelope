using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleDBContext;
using SimpleDBContext.Models;
using SimpleKonwWebDevelope.Filter;

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
        //���������
        //EF MVC Identity
        public void ConfigureServices(IServiceCollection services)
        {
            //https://stackoverflow.com/questions/58266344/net-core-3-mvc-using-usemvcwithdefaultroute-to-configure-mvc-is-not-suppo
            services.AddMvc(option => option.EnableEndpointRouting = false);

            /**
             * ������
             * 1.�쳣������
             * ��һ��ע��ķ�ʽ
             * ȫ��ע��
             * 
             * **/
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(typeof(CustomExceptionFilterAttribute));
            });

            //��һ��ʵ�ֵķ�ʽ
            //var connection = _configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<IdentityDBContext>(config => config.UseSqlServer(connection));
            //��Ӧ��IdentityDBContext д�����б仯

            //�ڶ���ʵ�ֵķ�ʽ
            //IdentityDBContext ��д OnConfiguring 
            services.AddEntityFrameworkSqlServer().AddDbContext<IdentityDBContext>();


            //AddIdentity ��Ҫ�����������Ͳ���
            //UserStore �����û�����֤������
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<IdentityDBContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //���ڶ���HTTP����ܵ����м��
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //������������Ϣչʾ������
            //��ע�ͣ�������ر���
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseWelcomePage();

            //app.UseDefaultFiles();
            //app.UseStaticFiles(); 

            app.UseFileServer();//�ȼ����������д���

            //��ʼʹ��MVC Ĭ��·�ɹ���
            //app.UseMvcWithDefaultRoute();

            //���� Identity �м����λ�÷ǳ���Ҫ������ڹܵ��в����м����ʱ��̫��������Զû�л��ᴦ������
            //https://www.cnblogs.com/lonelyxmas/p/9724398.html
            //��֤
            app.UseAuthentication();
            //Authentication`��֤`-���Ƿ�����Ա��
            //Claims
            //Authorization`��Ȩ`-�㲻�ǲ�����Ա

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
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=SimpleSelect}/{id?}");
        }
    }
}
