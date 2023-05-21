using CommonBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    public class FoodProductRequest : BaseEntity
    {
        protected string name;
        protected decimal price;
        protected int foodCode;
        public int FoodCode { get { return foodCode; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        public FoodProductRequest(int FoodCode)
        {
            foodCode = FoodCode;
        }
        internal FoodProductRequest()
        {
        }
    }
}
