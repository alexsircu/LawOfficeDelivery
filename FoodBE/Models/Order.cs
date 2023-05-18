using FoodBE.Common;
using FoodBE.FoodProducts;
using FoodBE.FoodProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.Models
{
    public class Order : BaseEntity
    {
        int orderId;
        public bool isReady;
        public int OrderId { get { return orderId; } }
        public readonly List<FoodProductOrder> foodItems;
        internal bool InPreparation;
        internal FoodProvider foodProvider;
        public FoodProvider FoodProvider { get { return foodProvider; } }

        public Order()
        {
            orderId = random.Next(100, 999);
            foodItems = new();
            // foodItems = basket.foodProductOrder;
        }
    }
}
