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
    internal class FullTimeFoodProviderFactory : FoodProviderFactory
    {
        public FullTimeFoodProviderFactory()
        {
            string[] args = { "McDonalds", "BugerKing", "Kebab Centrale", "Ristorante bella Napoli ", "Terrazza Aperol" };

            observers.Cast<FullTimeProvider>().ToList();
            FoodProviderUtility.CreateFoodProviders<FullTimeProvider>(this, args); // Fill observers list 

        }
        public override IFoodProductProvider CreateProductProvider(double Distance)
        {
            FullTimeProvider fp = (FullTimeProvider)observers.OrderByDescending(x => x.WaitingTime).First();
            return fp;
        }
    }
}
