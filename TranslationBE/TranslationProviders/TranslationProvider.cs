using CommonBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.AbstractFactory;
using TranslationBE.Models;
using TranslationBE.TranslationTexts;

namespace TranslationBE.TranslationProviders
{
    public class TranslationProvider : BaseEntity, ITranslationTextProvider
    {
        internal Queue<Order> Orders = new();
        bool operatorIsWorking;


        public async Task<OrderResponseTranslation> PlaceOrder(Basket basket)
        {
            return await CreateOrder(basket);
        }
        async Task<OrderResponseTranslation> CreateOrder(Basket basket)
        {
            Order newOrder = new();
            try
            {
                foreach (var item in basket.translationTextOrder)
                {
                    TranslationTextOrder translatonText = this.Menu.Where(i => i.FoodCode == item.FoodCode).FirstOrDefault();
                    translatonText.Order = newOrder;
                    newOrder.textItems.Add(translatonText);
                }

                if (Orders.Any()) this.Orders.Dequeue();
                this.Orders.Enqueue(newOrder);
                OrderResponseTranslation bag = await CompleteOrders(newOrder);
                return bag;
            }
            catch (Exception ex)
            {
                return new OrderResponseTranslation() { Error = ex.Message + "\n" + ex.StackTrace, Order = null };
            }

        }
        internal async Task<OrderResponseTranslation> CompleteOrders(Order OrderToComplete)
        {

            try
            {
                cookingPlate.Cook(OrderToComplete);

                while (OrderToComplete.foodItems.Where(f => f.isReady == false).Any())
                {
                    // Finchè c'è qualsosa in piastra
                }
                OrderToComplete.isReady = true;

                Console.WriteLine($" Elements in queue: {Orders.Count()} ");
                Console.WriteLine($" Removing from Queue .....");
                await Task.Delay(3000);

                Orders.TryDequeue(out OrderToComplete);

                Console.WriteLine($" Elements in queue: {Orders.Count()} ");


                return new OrderResponseTranslation() { Order = OrderToComplete };
            }
            catch
            {
                throw;
            }
        }
    }
}
