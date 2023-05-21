using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.AbstractFactory;

namespace TranslationBE.TranslationFactories
{
    public class EnglishProviderFactory : TranslationProviderFactory
    {
        public override ITranslationTextFactory CreateTranslationTextProvider(double Distance)
        {

        }
    }
}
