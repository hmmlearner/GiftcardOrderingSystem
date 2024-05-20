using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class GiftCardDto
    {
        //public string Code { get; set; } = default!;
        public string Message { get; set; } = default!;
        public decimal Balance { get; set; }
        public bool Activated { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
