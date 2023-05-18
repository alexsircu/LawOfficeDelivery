using FoodBE.DesignPattern.AbstractFactory;
using FoodBE.DesignPattern.Subject;
using FoodBE.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.FoodFactories
{
    public abstract class FoodProviderFactory : FoodSubject, IFoodProviderFactory
    {
        public abstract IFoodProductProvider CreateProductProvider(double Distance);

        public FoodProviderFactory()
        {
        }
    }
}
