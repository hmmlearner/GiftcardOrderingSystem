using Application.Common.Models;
using Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    internal interface IGCCartRepository 
    {
        public Task<Response<GiftCardDto>> AddToCart(int cardId, int quantity);

        public Task<Response<GiftCardDto>> DeleteFromCart(int cardId, int quantity);
        public Task<Response<GiftCardDto>> RetrieveCart();

        public Task<Response<string>> DeleteCart();
    }
}
