using AzureFunction.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Logging.AddApplicationInsights(configureTelemetryConfiguration: configuration =>
{
    configuration.ConnectionString = ConnectionStringHelper.GetAppInsightsInstrumentationKey();
}, _ => { });

builder.Build().Run();
