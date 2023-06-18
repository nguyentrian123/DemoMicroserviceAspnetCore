using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerceMainAPI_App.Controllers
{
    
    [ApiController]
    public class UsersController : ControllerBase
    {
        [Route("GetUserDetails")]
        [HttpGet]
        public async Task<UserModel> GetUserDetails()
        {
            UserModel obj = new UserModel();

            var url = "http://localhost:5233/GetUserDetails";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var strResult = response.Content.ReadAsStringAsync().Result;
                    obj = JsonConvert.DeserializeObject<UserModel>(strResult);
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            return obj;
        }
    }
}
