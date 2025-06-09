using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace AzureFunction
{
    public class MultiResponse
    {
        [QueueOutput("outqueue",Connection = "AzureWebJobsStorage")]
        public string[] Messages { get; set; }
        public HttpResponseData HttpResponse { get; set; }
    }
}