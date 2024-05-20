using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class GiftCardCreateDto
    {
        public string Message { get; set; } = default!;
        public decimal Balance { get; set; }
    }
}
