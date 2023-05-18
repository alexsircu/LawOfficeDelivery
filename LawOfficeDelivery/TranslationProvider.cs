using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Abstract;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class TranslationProvider : Provider, ITranslationFactory
    {
        public TranslationProvider(string name, string openingTime, string closingTime, double distance) : base(name, openingTime, closingTime, distance)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            List<Product> products = new List<Product>() {
                new Product(1, "Inglese", "00:30", 100M),
                new Product(2, "Tedesco", "1:00", 150M),
                new Product(3, "Francese", "00:45", 120M)
            };
        }

        //CONTRACTS
        public IProduct CreateText() 
        {
            return null;
        }
    }
}
