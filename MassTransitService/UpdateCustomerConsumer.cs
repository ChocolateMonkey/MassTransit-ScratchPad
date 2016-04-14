using MassTransit;
using MassTransitService.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransitService
{
    public class UpdateCustomerConsumer : IConsumer<UpateCustomerAddress>
    {
        public async Task Consume(ConsumeContext<UpateCustomerAddress> context)
        {
            var textReturn = $"Updating: {context.Message.HouseNumber} {context.Message.StreetName}";

            await Console.Out.WriteLineAsync(textReturn);
            Trace.TraceInformation(textReturn);
        }
    }
}
