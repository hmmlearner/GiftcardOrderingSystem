using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart: BaseEntity
    {
        public List<CartItem> Items { get; set; }

        public int CustomerId { get; set; }
        public DeliveryMode DeliveryMethod { get; set; }

        public double CartTotal { get; set; }

    }
}
