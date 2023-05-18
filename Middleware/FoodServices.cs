using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.DesignPattern.AbstractFactory;
using FoodBE.FoodProviders;
using FoodBE.FoodProducts;
using FoodBE.Models;

namespace Middleware
{
    public class FoodServices : Services
    {

        static IAbstractFoodServiceFactory ServiceFactory;
        static IFoodProviderFactory ProviderFactory;
        static IFoodProductProvider ProductProvider;
        public FoodProvider FoodProvider { get { return (FoodProvider)ProductProvider; } }

        public FoodServices()
        {

        }
        public void Start(ref char input)
        {
            ServiceFactory = ClientServicesFactory.CreateServiceFactory(ref input);
            // ProviderFactory = ServiceFactory.CreateProviderFactory(ref input);
        }
        public void CreateProviderFactory(ref char input)
        {
            ProviderFactory = ServiceFactory.CreateProviderFactory(ref input);
        }
        public void GetProvider(double distance)
        {
            ProductProvider = ProviderFactory.CreateProductProvider(distance);
        }
        public List<FoodProductRequest> GetMenu()
        {
            return ProductProvider.GetMenu();
        }
        public void AddToBasket(FoodProductRequest MenuItem)
        {
            basket.foodProductOrder.Add(MenuItem);
        }
        public void ShowBasket()
        {
        }
        public async Task<OrderResponse> SendOrder()
        {
            await Task.Delay(1000);

            if (basket.foodProductOrder.Count == 0)
            {
                return null;
            }
            OrderResponse ResOrder = await ProductProvider.PlaceOrder(basket);
            return ResOrder;
        }

    }
}
