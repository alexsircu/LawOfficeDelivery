using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBE.Models
{
    public class OrderResponse
    {
        public Order Order { get; internal set; }
        public string Error { get; internal set; }
    }
}
