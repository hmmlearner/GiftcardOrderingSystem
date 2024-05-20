using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Dto;

namespace Infrastructure.Repositories
{
    public class GiftCardRepository : IGiftCardRepository
    {
        public Task<Response<GiftCardDto>> CreateGiftCard(GiftCardCreateDto giftcard)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<GiftCardDto>>> GetAllGiftCardsByCustomer(int customerid)
        {
            throw new NotImplementedException();
        }

        public Task<Response<GiftCardDto>> GetGiftCardById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
