using Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IOrderRepository
    {
        public Task<Response<OrderRetrieveDto>> OrderConfirmation(int ordernumber, string sessionid);

        public Task<Response<string>> SubmitPayment();
        public Task<Response<OrderRetrieveDto>> RetrieveOrder(int ordernumber);
    }
}
