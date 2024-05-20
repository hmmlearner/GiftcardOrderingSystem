using Application.Common.Models;
using Application.Dto;

namespace Application.Common.Interfaces
{
    public interface IGiftCardRepository
    {
        public Task<Response<GiftCardDto>> GetGiftCardById(int id);
        public Task<Response<GiftCardDto>> CreateGiftCard(GiftCardCreateDto giftcard);

        public Task<Response<List<GiftCardDto>>> GetAllGiftCardsByCustomer(int customerid);


    }
}
