using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItems : BaseEntity
    {
        public int GiftCardId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
