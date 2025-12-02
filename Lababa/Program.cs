using Lababa.Backend.Data;
using Lababa.Backend.Services;
using Lababa.Frontend.Forms;
using Lababa.Frontend.UserControls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lababa
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            using (var scope = ServiceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<LababaDbContext>();
                dbContext.Database.EnsureCreated();
            }

            Application.Run(ServiceProvider.GetRequiredService<WizardForm>());
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<LababaDbContext>();

                    // services
                    services.AddScoped<ApplicationSettingsService>();
                    services.AddTransient<CustomerService>();
                    services.AddTransient<OrderService>();
                    services.AddTransient<ItemServiceCatalogService>();
                    services.AddTransient<WeightServiceCatalogService>();
                    services.AddTransient<OrderItemItemService>();
                    services.AddTransient<OrderWeightItemService>();

                    // forms
                    services.AddTransient<DashboardForm>();
                    services.AddTransient<AddCustomerForm>();
                    services.AddTransient<AddOrderForm>();
                    services.AddTransient<SearchOrderForm>();
                    services.AddTransient<WizardForm>();

                    // user controls
                    services.AddTransient<WelcomeStep>();
                    services.AddTransient<ShopInformationStep>();
                    services.AddTransient<WeightServicesStep>();
                    services.AddTransient<ItemServicesStep>();
                    services.AddTransient<FinishWizardStep>();
                });
    }
}
