using Application.Common.Interfaces;
using Application.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace GiftCardOrderingSystem.Controllers
{
    public class GiftCardCartController: ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IGiftCardRepository _cartRepository;

        public GiftCardCartController(ILogger logger, IGiftCardRepository cartRepository)
        {
            _logger = logger;
            _cartRepository = cartRepository;
        }

        /// <summary>
        /// Adds a Card to the cart.
        /// </summary>
        /// <param name="GiftCardID">The ID of the product to add.</param>
        /// <param name="quantity">The quantity of the product to add.</param>
        /// <returns>The updated shopping cart.</returns>
        [Route("AddToCart")]
        [HttpPost]
        public async Task<ActionResult<Response<GiftCardDto>>> AddToCart(int giftcarId, int quantity)
        {
            try
            {
                var addToCartReponse = await _cartRepository.AddToCart(giftcarId, quantity);
                return (addToCartReponse == null) ? BadRequest("Couldn't add item to cart") : Ok(addToCartReponse);

            }
            catch (Exception ex)
            {
                return BadRequest($"Couldn't add item to cart {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves the shopping cart.
        /// </summary>
        /// <returns>The shopping cart.</returns>
        [Route("RetrieveCart")]
        [HttpGet]
        public async Task<ActionResult<Response<CartRetrieveDto>>> RetrieveCart()
        {
            try
            {
                var cartReponse = await _cartRepository.RetrieveCart();
                return (cartReponse == null) ? BadRequest("Couldn't retrieve cart") : Ok(cartReponse);

            }
            catch (Exception ex)
            {
                return BadRequest($"Couldn't retrieve cart {ex.Message}");
            }
        }
        public void SubmitPayment()
        {
            // SubmitPayment logic
        }

        public void RetrieveOrder(int ordernumber)
        {
            // RetrieveOrder logic
        }
    }
}
