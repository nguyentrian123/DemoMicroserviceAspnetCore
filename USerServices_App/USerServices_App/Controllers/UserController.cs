using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace USerServices_App.Controllers
{
  
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("GetUserDetails")]
        [HttpGet]
        public UserModel GetUserDetails()
        {
            UserModel obj = new UserModel();

            obj.Email = "testemail@test.com";
            obj.UserId = 1001;
            obj.Name = "Test User";

            return obj;
        }
    }
}
