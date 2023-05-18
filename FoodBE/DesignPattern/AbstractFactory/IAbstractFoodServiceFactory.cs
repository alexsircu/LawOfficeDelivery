using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.DesignPattern.AbstractFactory
{
    public interface IAbstractFoodServiceFactory
    {
        public IFoodProviderFactory CreateProviderFactory(ref char input);
    }
}
