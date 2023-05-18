using FoodBE.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProviders
{
    class BreakfastProvider : FoodProvider, IBreakfast
    {
        public BreakfastProvider(string Name) : base(Name)
        {
            opening = new TimeSpan(07);
            closing = new TimeSpan(12);
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.BREAKFAST);
        }
        public BreakfastProvider()
        {
            opening = new TimeSpan(07);
            closing = new TimeSpan(12);
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.BREAKFAST);
        }
    }
}
