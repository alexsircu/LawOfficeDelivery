using FoodBE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    class Burger : FoodProduct
    {
        internal override string[] DevivedProducts { get { return new string[] { "BigMac", "Cheese Burger", "Royal burger" }; } }

        public Burger(decimal Price, string Name) : base(Price, Name)
        {
            MealOfferType.Add(MealType.LUNCH);
            MealOfferType.Add(MealType.DINNER);
            preperationTime = 10000;
        }
        public Burger()
        {
            MealOfferType.Add(MealType.LUNCH);
            MealOfferType.Add(MealType.DINNER);
            preperationTime = 10000;

        }
    }
}
