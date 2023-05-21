using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBE.DesignPattern;
using TranslationBE.TranslationProducts;

namespace TranslationBE.DesignPattern.Observer
{
    public interface ITranslationTextObserver : IObserver 
    {
        public List<TranslationTextRequest> GetOperators();
    }
}
