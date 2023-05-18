using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.Models;

namespace FoodBE.FoodProducts
{
    public abstract class FoodProductOrder : FoodProductRequest
    {
        Order order;
        internal Order Order { get; set; }
        internal bool isReady;
        internal bool inPreparation;
        internal int PreperationTime { get; }

        internal FoodProductOrder(Order Order)
        {
            order = Order;
        }
        internal FoodProductOrder()
        {

        }
    }
}
