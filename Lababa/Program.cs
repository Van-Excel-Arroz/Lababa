using Lababa.Backend.Data;
using Lababa.Backend.Services;
using Lababa.Frontend.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lababa
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new DashboardForm());
            //Application.Run(new WizardForm());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<LababaDbContext>();

                    // services
                    services.AddSingleton<ApplicationSettingsService>();
                    services.AddTransient<CustomerService>();
                    services.AddTransient<OrderService>();
                    services.AddTransient<ItemServiceCatalogService>();
                    services.AddTransient<WeightServiceCatalogService>();
                    services.AddTransient<OrderItemItemService>();
                    services.AddTransient<OrderWeightItemService>();

                    // forms
                });
    }
}
