using FoodBE.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoodBE.FoodProducts
{
    public abstract class FoodProduct : FoodProductOrder
    {
        protected string description;
        protected int preperationTime;

        public FoodProduct(decimal Price, string Name) : base()
        {
            price = Price;
            name = Name;
            foodCode = random.Next(100, 999);
            MealOfferType = new List<MealType>();
        }
        public FoodProduct()
        {
            MealOfferType = new List<MealType>();
        }

        // internal  int PreperationTime { get { return preperationTime; } }
        internal abstract string[] DevivedProducts { get; }
        internal List<MealType> MealOfferType { get; }


        public double GetTime()
        {
            //  Fake time of preparation 
            Thread.Sleep(random.Next(1000, 10000));
            return new TimeSpan(random.Next(60, 3600)).TotalMinutes;
        }
    }
}
