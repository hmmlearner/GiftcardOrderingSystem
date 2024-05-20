using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GiftCard :BaseEntity
    {
        public string Code { get; set; } = default!;
        public string Message { get; set; } = default!;
        public decimal Balance { get; set; }
        public bool Activated { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
