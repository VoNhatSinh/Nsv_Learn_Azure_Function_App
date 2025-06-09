namespace AzureFunction.Services
{
    public static class ConnectionStringHelper
    {
        public static string GetAppInsightsInstrumentationKey()
        {
            return Environment.GetEnvironmentVariable(
                "APPLICATIONINSIGHTS_CONNECTION_STRING");
        }
    }
}