using FoodBE.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.Utilities;
using FoodBE.FoodProviders;
using FoodBE.DesignPattern.AbstractFactory;

namespace FoodBE.FoodFactories
{
    internal class PartTimeFoodProviderFactory : FoodProviderFactory
    {
        public PartTimeFoodProviderFactory()
        {
            string[] args = { "McDonalds", "BugerKing", "Pizzeria centrale", "Shushi Wu" };

            observers.Cast<PartTimeProvider>().ToList();
            FoodProviderUtility.CreateFoodProviders<PartTimeProvider>(this, args); // Fill observers list 
        }
        public override IFoodProductProvider CreateProductProvider(double Distance)
        {
            PartTimeProvider fp = (PartTimeProvider)observers.OrderByDescending(x => x.WaitingTime).First();
            return fp;
        }
    }
}
