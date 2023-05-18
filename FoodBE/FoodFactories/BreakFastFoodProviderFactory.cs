using FoodBE.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.FoodProviders;
using FoodBE.Utilities;
using FoodBE.DesignPattern.AbstractFactory;

namespace FoodBE.FoodFactories
{
    internal class BreakFastFoodProviderFactory : FoodProviderFactory
    {
        public BreakFastFoodProviderFactory()
        {
            string[] args = { "McCafé ", "Starbucks", "Bar Centrale", "Bar Duomo", "Bar FS" };
            observers.Cast<BreakfastProvider>(); // Lista vuota  
            FoodProviderUtility.CreateFoodProviders<BreakfastProvider>(this, args); // Fill observers list 
            FoodProviderUtility.CreateFakeOrders(observers);
        }
        public override IFoodProductProvider CreateProductProvider(double Distance)
        {
            BreakfastProvider fp = (BreakfastProvider)observers.OrderByDescending(x => x.WaitingTime).First();
            return fp;
        }
    }
}
