using IoTHubTrigger = Microsoft.Azure.WebJobs.ServiceBus.EventHubTriggerAttribute;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

// teXXmoAction is a function that receives communication from IoT Hub using the events end-point.

namespace MyAzureIoTButton
{

    public static class teXXmoAction
    {

        private static HttpClient client = new HttpClient(); // creating object of HttpClient
        [FunctionName("teXXmoAction")]

        public static async System.Threading.Tasks.Task RunAsync([IoTHubTrigger("messages/events", Connection = "IoTHubConnectionString")]EventData message, TraceWriter log)
        {
            // logging the HTTP trigger and then calling the logic app hosted in Azure
            log.Info("C# HTTP trigger function processed a request.");
            // pointing to the URL where the Logic App is hosted
            await client.PostAsync("https://prod-15.westus.logic.azure.com:443/workflows/01433f625eaf4a86a6ce165759a17c8f/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=elEC2HJqRTa0kZbt8rAk3bGuiu2uvfTjZGRkJ-pkYaM", null);
        }
    }

}
