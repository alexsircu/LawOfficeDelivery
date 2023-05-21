using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.TranslationFactories;
using TranslationBE.TranslationProviders;

namespace TranslationBE.Utilities
{
    internal class TranslationUtility
    {
        internal static List<T> CreateTranslationProviders<T>(TranslationProviderFactory translationProviderFactory, string[] args) where T : TranslationProvider, new()
        {
            T t = new T();
            Type type = t.GetType();
            int random = new Random().Next(5);
            List<T> translationProviders = new();

            for (int i = 0; i < args.Length; i++)
            {
                var obj = (T)Activator.CreateInstance(type, args[i]);
                translationProviders.Add(obj); 
            }
            translationProviders.Cast<T>().ToList();
            translationProviders.ForEach(tp => translationProviderFactory.Attach(tp)); // Fill IObserver's list 
            return translationProviders;
        }
        internal async static void CreateFakeOrders(List<TranslationProvider> translationProviders)
        {
            List<Task<bool>> tasks = new List<Task<bool>>();
            foreach (var Provider in translationProviders)
            {
                tasks.Add(Task.Run(() => CreateFakeOrder(Provider, Provider.Menu)));
            }
            await Task.WhenAll(tasks);
        }
        internal static async Task<bool> CreateFakeOrder(TranslationProvider translationProvider, List<TranslationText> foodProductOrder)
        {
            Order newOrder = new();
            try
            {
                foreach (var item in foodProductOrder)
                {
                    FoodProduct foodProduct = foodProvider.Menu.Where(i => i.FoodCode == item.FoodCode).FirstOrDefault();
                    foodProduct.Order = newOrder;
                    newOrder.foodItems.Add(foodProduct);
                }

                foodProvider.Orders.Enqueue(newOrder);
                await Task.Delay(3000);
                return true;
            }
            catch (Exception ex)
            {
                return false;

                throw;
            }
        }
    }
}
