using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.DesignPattern.AbstractFactory;
using FoodBE.FoodFactories;

namespace Middleware
{
    public class ClientServicesFactory
    {
        public static IAbstractFoodServiceFactory CreateServiceFactory(ref char input)
        {
            if (input == 'Q')
                return null;

            var inputNumber = CharUnicodeInfo.GetDecimalDigitValue(input);

            switch (inputNumber)
            {
                case 1:
                    return new AbstractFoodProviderFactory();

                case 2:
                    return null;
                default:
                    return null;
            }
        }
    }
}
