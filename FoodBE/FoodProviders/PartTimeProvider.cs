using FoodBE.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProviders
{
    class PartTimeProvider : FoodProvider, IBreakfast, ILunch, ISnack
    {
        public PartTimeProvider(string Name) : base(Name)
        {
            opening = new TimeSpan(07); //  07:00 AM
            closing = new TimeSpan(14); //  14:00 PM
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.BREAKFAST);
        }
        public PartTimeProvider()
        {
            opening = new TimeSpan(07);
            closing = new TimeSpan(14);
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.BREAKFAST);
        }
    }
}
