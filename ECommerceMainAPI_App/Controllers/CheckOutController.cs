using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceMainAPI_App.Controllers
{
    
    [ApiController]
    public class CheckOutController : ControllerBase
    {
        [Route("CheckOut")]
        [HttpPost]

        public string CheckOut(CheckoutModel objmodel)
        {
            return "Order checked out successfull.";
        }
    }
}
