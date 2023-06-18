using ECommerceDataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService_App.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("GetProductList")]
        [HttpGet]
        public async Task<List<ProductModel>> GetProductList()
        {
            List<ProductModel> Productlist = new List<ProductModel>
            {
                new ProductModel { Id=1,Category="Programming Book",Name="Effective C#",Price=300 },
                new ProductModel { Id=2,Category="Autobiography",Name="My Experiment with truth",Price=500 },
                new ProductModel {Id=3,Category="Programming Book",Name="Programming in C#",Price=330 },
                new ProductModel { Id=4,Category="Programming Book",Name="Beginning Visual C# 2010",Price=600 },
                new ProductModel { Id=5,Category="Autobiography",Name="My Experiment with false",Price=500 },
                new ProductModel {Id=6,Category="Programming Book",Name="C# in Depth",Price=330 }

            };

            return Productlist;


        }
    }
}
