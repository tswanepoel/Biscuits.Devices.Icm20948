namespace Biscuits.Devices.Icm20948.Tests
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Serilog;
    using Xunit.Abstractions;

    public class Icm20948Fixture : IDisposable
    {
        private readonly ServiceProvider _serviceProvider;

        public Icm20948Fixture(ITestOutputHelper output)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .WriteTo.TestOutput(output)
                .Destructure.ByTransforming<byte[]>(b => BitConverter.ToString(b).Replace('-', ' '))
                .CreateLogger();

            var services = new ServiceCollection();

            services.AddLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddSerilog();
            });
            
            services.Configure<Icm20948Options>(configuration.GetSection("Icm20948Options"));

            services.AddSingleton<Icm20948Spi>(serviceProvider =>
            {
                var options = serviceProvider.GetRequiredService<IOptions<Icm20948Options>>().Value;
                var logger = serviceProvider.GetRequiredService<ILogger<Icm20948Spi>>();

                return new Icm20948Spi(options.BusId, options.ChipSelectLine ?? -1, logger);
            });

            services.AddTransient<Icm20948Programmer>();
            services.AddTransient<Icm20948Dmp3>();

            _serviceProvider = services.BuildServiceProvider();
        }

        public ILoggerFactory LoggerFactory { get => _serviceProvider.GetRequiredService<ILoggerFactory>(); }
        public Icm20948Spi Icm20948 { get => _serviceProvider.GetRequiredService<Icm20948Spi>(); }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _serviceProvider?.Dispose();
        }
    }
}