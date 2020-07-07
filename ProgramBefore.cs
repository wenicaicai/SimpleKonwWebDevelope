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
            CreateHostBuilder(args).Build().Run();//��������������֮��
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)//�����������󣨷�װһ����������Ҫ�ķ���
                .ConfigureWebHostDefaults(webBuilder =>//����Ĭ�ϵ�Web����������Ӧ�ó��򡢼����ڣ�
                {
                    /**
                     * ���ü����˿ںš���IP
                     * ��ʼ��һЩ����
                     * ����ע�� ���÷���(����-Web����)
                     * 
                     */
                    webBuilder.UseStartup<Startup>();//���ùܵ����м��
                    //Kestrel ��Ĭ�϶˿���http 5000 ��http5001
                    webBuilder.ConfigureKestrel(options=>
                    {
                        options.ListenAnyIP(5180);
                    });
                });
    }
}
