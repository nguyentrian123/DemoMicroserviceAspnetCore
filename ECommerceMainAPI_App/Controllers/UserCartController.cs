using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceMainAPI_App.Controllers
{
    
    [ApiController]
    public class UserCartController : ControllerBase
    {
        [Route("AddtoCart")]
        [HttpPost]

        public List<UserCart> AddtoCart(UserCart objCart)
        {
            List<UserCart> ItemList = new List<UserCart>
            {
                new UserCart { UserId=objCart.UserId,ProductId=objCart.ProductId,ProductPrice=objCart.ProductPrice,ProductQuantity=objCart.ProductQuantity }

            };

            return ItemList;
        }
    }
}
