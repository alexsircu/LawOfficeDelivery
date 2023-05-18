using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.Models;

namespace Middleware
{
    public class Services
    {
        protected Basket basket;
        public Basket Basket { get { return basket; } }

        public Services()
        {
            basket = new();
        }
    }
}
