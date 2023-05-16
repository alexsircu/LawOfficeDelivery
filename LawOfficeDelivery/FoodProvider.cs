using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Abstract;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class FoodProvider : Provider, IOrderProviderFactory
    {
    }
}
