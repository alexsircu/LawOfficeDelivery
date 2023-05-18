using LawOfficeDelivery.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeDelivery.Abstract
{
    internal abstract class Provider
    {
        string _name;
        TimeSpan _openingTime;
        TimeSpan _closingTime;
        TimeSpan _waitingTime;
        List<Product> _products;
        double _distance;

        public string Name { get => _name; set => _name = value; }
        public TimeSpan OpeningTime { get => _openingTime; set => _openingTime = value; }
        public TimeSpan ClosingTime { get => _closingTime; set => _closingTime = value; }
        public TimeSpan WaitingTime { get => _waitingTime; set => _waitingTime = value; }
        public List<Product> Products { get => _products; set => _products = value; }
        public double Distance { get => _distance; set => _distance = value; }

        public Provider(string name, string openingTime, string closingTime, double distance)
        {
            Name = name;
            OpeningTime = TimeSpan.Parse(openingTime);
            ClosingTime = TimeSpan.Parse(closingTime);
            Distance = distance;
        }

        protected void CalcWaitingTime()
        {
            //TODO: calcolo tempo in base ai prodotti che si stanno cucinando
        }

        internal class Product
        {
            int _id;
            string _name;
            TimeSpan _preparationTime;
            decimal _price;

            public int Id { get => _id; set => _id = value; }
            public string Name { get => _name; set => _name = value; }
            public TimeSpan PreparationTime { get => _preparationTime; set => _preparationTime = value; }
            public decimal Price { get => _price; set => _price = value; }

            public Product(int id, string name, string preparationTime, decimal price)
            {
                Id = id;
                Name = name;
                PreparationTime = TimeSpan.Parse(preparationTime);
                Price = price;
            }
        }
    }
}
