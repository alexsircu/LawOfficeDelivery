using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.Observer;
using TranslationBE.Models;

namespace TranslationBE.DesignPattern.AbstractFactory
{
    public interface ITranslationTextProvider : ITranslationTextObserver
    {
        public bool CheckIsOpened();
        public Task<OrderResponseTranslation> PlaceOrder(Basket basket);
    }
}
