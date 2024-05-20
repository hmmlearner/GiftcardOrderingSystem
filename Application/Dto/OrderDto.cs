using System;
using Domain.Enums;

namespace Application.Dto
{
    internal class OrderDto
    {
        public int OrderNumber { get; set; }
        public CustomerDto Customer { get; set; }
        public List<OrderItemsDto> Items { get; set; }
        public DeliveryMode DeliveryType { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Surcharge { get; set; }
        public decimal Total { get; set; }

    }
}
