using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationBE.DesignPattern.AbstractFactory
{
    public interface IAbstractTranslationServiceFactory
    {
        public ITranslationProviderFactory CreateProviderFactory(ref char input);
    }
}
