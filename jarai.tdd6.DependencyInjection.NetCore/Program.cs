using jarai.tdd6.DependencyInjection.DIY.Application;
using jarai.tdd6.DependencyInjection.DIY.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace jarai.tdd6.DependencyInjection.NetCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var hostBuilder = CreateHostBuilder(args);
        using var host = hostBuilder.Build();

        var serviceProvider = host.Services.CreateScope().ServiceProvider;

        try
        {
            var app = serviceProvider.GetRequiredService<Applikation>();
            app.Run();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static IHostBuilder CreateHostBuilder(string[] strings)
    {
        var hostBuilder = Host.CreateDefaultBuilder();

        hostBuilder.ConfigureServices((_, services) =>
        {
            // Registrierung aller Abhängigkeiten
            services.AddSingleton<ViewModel>(); // Singleton => Eine einzige Instanz für Alle
            services.AddSingleton<Lagerverwaltung>();
            services.AddSingleton<Buchhaltung>();
            services.AddSingleton<UserInterface>();
            services.AddSingleton<KontoFactory>();
            services.AddSingleton<Bestellservice>();
            services.AddSingleton<Versandservice>();

            // https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences
            //services.AddSingleton<ILogger, FileLogger>();
            //services.AddScoped<ILogger, ConsoleLogger>();
            services.AddTransient<ILogger, ConsoleLogger>(); // transient => Eine neue Instanz für jeden

            services.AddSingleton<Applikation>();
        });

        return hostBuilder;
    }
}