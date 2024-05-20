using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order: BaseEntity
    {
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; } = default!;
        public List<OrderItems> Items { get; set; } = default!;
        public DeliveryMode DeliveryType { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Surcharge { get; set; }
        public decimal Total { get; set; }

        public DateTime OrderDate { get; set; }

        public Address ShippingAddress { get; set; } = default!;
        public Address BillingAddress { get; set; } = default!;

    }
}
