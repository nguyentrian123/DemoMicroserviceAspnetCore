using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerceMainAPI_App.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("GetProductList")]
        [HttpGet]
        public async Task<List<ProductModel>>   GetProductList()
        {
           

            List<ProductModel> Productlist = new List<ProductModel>();
            var url = "http://localhost:5219/GetProductList";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var strResult = response.Content.ReadAsStringAsync().Result;
                    Productlist = JsonConvert.DeserializeObject<List<ProductModel>>(strResult);
                    return Productlist;
                }
                else
                {
                    return null;
                }
            }
            return Productlist;

        }
    }
}
