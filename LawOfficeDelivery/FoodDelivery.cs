using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Abstract;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class FoodDelivery : Delivery, IFoodProviderFactory
    {
        public FoodDelivery(string name) : base(name)
        {

        }

        public override void AddProvider(Provider provider)
        {
            FoodProvider foodProvider = (FoodProvider)provider;
            Providers.Add(foodProvider);
        }

        public void Order()
        {

            //TODO: calcolo con .Then anche dei tempi di attesa del provider, in base a distanza e tempo di attesa si sceglie il provider migliore
            //Magari serve dare una velocità di default al rider e in base a quello calcolare se ci mette di meno a fare x km o aspettare y tempo

            Provider provider = Providers.OrderBy(item => item.Distance).First();

            FoodProvider foodProvider = (FoodProvider)provider;
            Console.WriteLine(foodProvider.CreateFoodMenu());
            Console.WriteLine("Ciao");
        }
    }
}
