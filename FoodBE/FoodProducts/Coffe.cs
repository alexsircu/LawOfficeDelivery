using FoodBE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    class Coffe : FoodProduct
    {
        internal override string[] DevivedProducts { get { return new string[] { "Caffe normale", "Caffe Macchiato", "Cappuccino", "Latte Macchiato", "Marrochino" }; } }
        public Coffe(decimal Price, string Name) : base(Price, Name)
        {
            MealOfferType.Add(MealType.BREAKFAST);
            preperationTime = 10000;
        }

        public Coffe()
        {
            MealOfferType.Add(MealType.BREAKFAST);
            preperationTime = 10000;

        }
    }
}
