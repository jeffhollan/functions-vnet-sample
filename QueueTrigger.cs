using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public static void Run([ServiceBusTrigger("queue", Connection = "jehollanpremium_SERVICEBUS")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"A CHANGE. C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
