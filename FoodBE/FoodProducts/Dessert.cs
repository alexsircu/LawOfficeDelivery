using FoodBE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    class Dessert : FoodProduct
    {
        internal override string[] DevivedProducts { get { return new string[] { "Caffe normale", "Caffe Macchiato", "Cappuccino", "Latte Macchiato", "Marrochino" }; } }

        public Dessert(decimal Price, string Name) : base(Price, Name)
        {

            MealOfferType.Add(MealType.LUNCH);
            MealOfferType.Add(MealType.DINNER);
            preperationTime = 10000;

        }
        public Dessert()
        {
            MealOfferType.Add(MealType.LUNCH);
            MealOfferType.Add(MealType.DINNER);
            preperationTime = 10000;

        }
    }
}
