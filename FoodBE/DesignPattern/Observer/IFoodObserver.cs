using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.FoodProducts;

namespace FoodBE.DesignPattern.Observer
{
    public interface IFoodObserver : IObserver
    {
        public List<FoodProductRequest> GetMenu();
    }
}
