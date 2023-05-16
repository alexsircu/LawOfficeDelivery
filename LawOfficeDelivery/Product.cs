using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfficeDelivery
{
    internal class Product
    {
        int _id;
        string _name;
        DateTime _preparationTime;
        decimal _price;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime PreparationTime { get => _preparationTime; set => _preparationTime = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
}
