using FoodBE.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodProviders
{
    class FullTimeProvider : FoodProvider, IBreakfast, ILunch, ISnack, IDinner
    {
        public FullTimeProvider(string Name) : base(Name)
        {
            opening = new TimeSpan(07);
            closing = new TimeSpan(24);
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.DINNER);

        }
        public FullTimeProvider()
        {
            opening = new TimeSpan(07);
            closing = new TimeSpan(24);
            Menu = Utilities.FoodProviderUtility.CreateMenu(Enum.MealType.DINNER);
        }
    }
}
