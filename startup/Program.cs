
using Core.Ports.Inbound.Services;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using startup.Configuration;

namespace startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();


            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddScoped<ITestService, TestService>();
            builder.Services.AddLogging(logging =>
            {
                logging.AddConsole();
                logging.AddDebug();
                logging.SetMinimumLevel(LogLevel.Debug);
            });

            builder.AddServicesConfiguration();            

            var app = builder.Build();

            var logger = app.Services.GetRequiredService<ILogger<Program>>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
