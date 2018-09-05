using IoTHubTrigger = Microsoft.Azure.WebJobs.ServiceBus.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
//using System.IO;
//using Microsoft.AspNetCore.Mvc;
//using IoTHubTrigger = Microsoft.Azure.WebJobs.ServiceBus.EventHubTriggerAttribute;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Azure.WebJobs.Host;
//using Newtonsoft.Json;
//using System.Threading.Tasks;
//using System.Net.Http;
//using Microsoft.Azure.EventHubs;

namespace MyAzureIoTButton
{



    public static class Function1
    {

        private static HttpClient client = new HttpClient();
        [FunctionName("Function1")]

        //public static async Task<IActionResult> RunAsync([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        public static async System.Threading.Tasks.Task RunAsync([IoTHubTrigger("messages/events", Connection = "IoTHubConnectionString")]EventData message, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");




            await client.PostAsync("https://prod-15.westus.logic.azure.com:443/workflows/01433f625eaf4a86a6ce165759a17c8f/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=elEC2HJqRTa0kZbt8rAk3bGuiu2uvfTjZGRkJ-pkYaM", null);



            //string name = req.Query["name"];

            //string requestBody = new StreamReader(req.Body).ReadToEnd();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //return name != null
            //    ? (ActionResult)new OkObjectResult($"Hello, {name}")
            //    : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }



}
