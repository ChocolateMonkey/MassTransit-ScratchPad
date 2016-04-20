using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransitService.Contracts
{
    public interface UpateCustomerAddress
    {
        Guid CommandId { get; set; }

        int HouseNumber { get; set; }

        string StreetName { get; set; }
    }

    public interface CheckOrderStatus
    {
        string OrderId { get; }
    }

    public interface OrderStatusResult
    {
        string OrderId { get; }
        DateTime Timestamp { get; }
        short StatusCode { get; }
        string StatusText { get; }
    }
}
