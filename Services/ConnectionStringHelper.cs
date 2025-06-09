namespace AzureFunction.Services
{
    public static class ConnectionStringHelper
    {
        public static string GetAppInsightsInstrumentationKey()
        {
            return Environment.GetEnvironmentVariable(
                "APPSETTING_APPLICATIONINSIGHTS_CONNECTION_STRING");
        }
    }
}