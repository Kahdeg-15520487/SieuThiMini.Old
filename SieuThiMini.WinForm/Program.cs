using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using SieuThiMini.AppService;
using SieuThiMini.DAL;

namespace SieuThiMini.WinForm
{
    static class Program
    {
        private static IConfigurationRoot Configuration { get; set; }
        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configuration = BuildConfiguration().Build();
            ServiceProvider = ConfigureServices().BuildServiceProvider();

            Application.Run(ServiceProvider.GetService<MainForm>());
        }

        static IConfigurationBuilder BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        }

        static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<SieuThiDbContext>(
                options => options.UseSqlServer
                        (
                            Configuration["ConnectionStrings:DefaultConnection"]
                        )
                );

            services.AddSieuThiService();

            services.AddTransient<MainForm>();

            services.AddTransient<DanhSachSanPham>();
            services.AddTransient<ChiTietSanPham>();

            return services;
        }
    }
}
