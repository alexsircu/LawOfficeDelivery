using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.DesignPattern.Observer;
using FoodBE.Models;

namespace FoodBE.DesignPattern.AbstractFactory
{
    public interface IFoodProductProvider : IFoodObserver
    {
        public bool CheckIsOpened();
        public Task<OrderResponse> PlaceOrder(Basket basket);
    }
}
