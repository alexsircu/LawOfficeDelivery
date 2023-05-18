using FoodBE.FoodProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.Models
{
    public class Basket
    {
        public List<FoodProductRequest> foodProductOrder;
        public Basket()
        {
            foodProductOrder = new();
        }
    }
}
