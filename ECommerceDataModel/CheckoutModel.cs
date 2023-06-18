using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDataModel
{
    public class CheckoutModel
    {
        public string OrderID { get; set; }
        public string OrderAmount { get; set; }

        public List<UserCart> LstCart;

    }
}
