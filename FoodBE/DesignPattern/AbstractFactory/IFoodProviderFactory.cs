using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.Models;

namespace FoodBE.DesignPattern.AbstractFactory
{
    public interface IFoodProviderFactory
    {
        public IFoodProductProvider CreateProductProvider(double Distance);
    }
}
