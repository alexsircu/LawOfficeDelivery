using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Abstract;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class FoodProvider : Provider, IFoodFactory
    {
        public FoodProvider(string name, string openingTime, string closingTime, double distance) : base(name, openingTime, closingTime, distance)
        {
            AddProduct(name);
        }

        public List<string> GetMenu()
        {
            List<string> menu = new List<string>();
            foreach (Product prod in Products)
            {
                menu.Add(prod.Name);
            }
            return menu;
        }

        private void AddProduct(string name)
        {
            if (name == "Starbucks")
            {
                List<Product> Products = new List<Product>() {
                    new Product(1, "American Coffee", "00:02", 2.00M),
                    new Product(2, "White Mocha", "00:03", 3.00M),
                    new Product(3, "Espresso", "00:01", 1.00M),
                    new Product(4, "Chocolate Brownie", "00:08", 4.00M),
                    new Product(5, "Cinnamon Swirl", "00:06", 5.00M),
                };
            }

            if (name == "McDonald's")
            {
                List<Product> Products = new List<Product>() {
                    new Product(1, "Big Mac", "00:04", 4.00M),
                    new Product(2, "McChicken", "00:03", 3.00M),
                    new Product(3, "CheesBurger", "00:02", 1.40M),
                    new Product(4, "Espresso", "00:01", 1.00M),
                    new Product(5, "Patate regolari", "00:02", 1.40M),
                };
            }
        }

        //CONTRACTS
        public IProduct CreateFoodMenu()
        {
            return null;
        }

        public IProduct CreateFoodOrder()
        {
            return null;
        }
    }
}
