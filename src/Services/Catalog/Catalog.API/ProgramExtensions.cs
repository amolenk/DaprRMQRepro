// Only use in this file to avoid conflicts with Microsoft.Extensions.Logging
using Serilog;

namespace Microsoft.eShopOnDapr.Services.Catalog.API;

public static class ProgramExtensions
{
    private const string AppName = "Catalog API";

    public static void AddCustomSerilog(this WebApplicationBuilder builder)
    {
        var seqServerUrl = builder.Configuration["SeqServerUrl"];

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .WriteTo.Console()
            .Enrich.WithProperty("ApplicationName", AppName)
            .CreateLogger();

        builder.Host.UseSerilog();
    }
}
