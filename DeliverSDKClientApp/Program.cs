using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Builders.DeliveryClient;
using KontentAiModels;
using System;
using System.Threading.Tasks;

namespace DeliverSDKClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Initializes a client
            IDeliveryClient deliveryClient = DeliveryClientBuilder
                .WithProjectId("64a5fac3-fe1d-00f6-4b06-c214e42687e2")
                .Build();


            // Strongly-typed model retrieval
            var datetimeItems = await deliveryClient.GetItemsAsync<DatetimeType>();
        }
    }
}
