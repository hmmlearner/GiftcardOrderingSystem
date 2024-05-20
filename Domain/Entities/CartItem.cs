using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class CartItem
    {
        public int GiftCardId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }
}
