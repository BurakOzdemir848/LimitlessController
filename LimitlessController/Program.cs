using LimitlessController.Core;
using LimitlessController.Core.Models;
using LimitlessController.Core.Services;
using LimitlessController.Infrastructure.Services;
using LimitlessController.Infrastructure.Tcp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace LimitlessController
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();

            Application.Run(host.Services.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    
                    services.AddSingleton<IDataConverter, HexConverter>();
                    services.AddSingleton<IDataConverter, BinaryConverter>();
                    services.AddSingleton<IDataConverter, ASCIIStringConverter>();
                    services.AddSingleton<IDataConverter, Utf8StringConverter>();
                    services.AddSingleton<IDataConverter, FloatConverter>();
                    services.AddSingleton<IDataConverter, DoubleConverter>();
                    services.AddSingleton<IDataConverter, Int16Converter>();
                    services.AddSingleton<IDataConverter, UInt16Converter>();
                    services.AddSingleton<IDataConverter, Int32Converter>();
                    services.AddSingleton<IDataConverter, UInt32Converter>();
                    services.AddSingleton<IDataConverter, Int64Converter>();
                    services.AddSingleton<IDataConverter, UInt64Converter>();
                    services.AddSingleton<IDataConverter, DecimalConverter>();

                    
                    services.AddSingleton<ConverterFactory>();

                    services.AddSingleton<IConnection, ConnectionManager>();

                    services.AddSingleton<MessageService>();


                    services.AddSingleton<Form1>();
                });
        }
    }
}