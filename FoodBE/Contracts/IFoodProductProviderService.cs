using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.Models;

namespace FoodBE.Contracts
{
    public interface IFoodProductProviderService
    {
        public void SendOrder(Basket basket);
        public void CheckMenu(Basket basket);
        public bool CheckIsOpened();
    }
}
