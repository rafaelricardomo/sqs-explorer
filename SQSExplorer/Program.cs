using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SQSExplorer.Core.Interfaces;
using SQSExplorer.Core.Serviços;
using SQSExplorer.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQSExplorer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            Application.Run((MainForm)ServiceProvider.GetService(typeof(MainForm)));
        }

        private static IServiceProvider ServiceProvider { get; set; }
        public static IConfiguration Configuration;

        static void ConfigureServices()
        {
            Configuration = LoadConfiguration();

            var services = new ServiceCollection();
            
            services.AddSingleton<IQueueService, QueueService>();
            services.AddSingleton<IMessageService, MessageService>();
            services.AddSingleton<IQueueRepository, QueueRepository>();
            services.AddSingleton<IMessageRepository, MessageRepository>();
            services.AddSingleton(Configuration);
            services.AddSingleton<MainForm>().AddLogging(configure => configure.AddConsole());
            services.AddSingleton<MessageForm>().AddLogging(configure => configure.AddConsole());


            ServiceProvider = services.BuildServiceProvider();
        }

        static IConfigurationRoot LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
