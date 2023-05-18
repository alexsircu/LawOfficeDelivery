using FoodBE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    class Drink : FoodProduct
    {
        bool isSoda = false;
        internal override string[] DevivedProducts { get { return new string[] { "Caffe normale", "Caffe Macchiato", "Cappuccino", "Latte Macchiato", "Marrochino" }; } }


        public Drink(decimal Price, string Name) : base(Price, Name)
        {
            MealOfferType.Add(MealType.ALL);
            preperationTime = 10000;

        }
        public Drink()
        {
            MealOfferType.Add(MealType.ALL);
            preperationTime = 10000;


        }
    }
}
