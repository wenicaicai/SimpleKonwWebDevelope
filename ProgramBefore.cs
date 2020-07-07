using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SimpleKonwWebDevelope
{
    public class ProgramBefore
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();//启动，构建好了之后
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)//主机构建对象（封装一个程序所需要的服务）
                .ConfigureWebHostDefaults(webBuilder =>//配置默认的Web主机（负责应用程序、寄宿在）
                {
                    /**
                     * 配置监听端口号、绑定IP
                     * 初始化一些服务
                     * 依赖注入 配置服务(主机-Web环境)
                     * 
                     */
                    webBuilder.UseStartup<Startup>();//配置管道、中间件
                    //Kestrel 的默认端口是http 5000 、http5001
                    webBuilder.ConfigureKestrel(options=>
                    {
                        options.ListenAnyIP(5180);
                    });
                });
    }
}
