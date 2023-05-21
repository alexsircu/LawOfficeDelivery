using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.AbstractFactory;

namespace TranslationBE.TranslationFactories
{
    public class AbstractTranslationProviderFactory : IAbstractTranslationServiceFactory
    {
        public AbstractTranslationProviderFactory()
        {

        }
        public ITranslationProviderFactory CreateProviderFactory(ref char input)
        {
            var inputNumber = CharUnicodeInfo.GetDecimalDigitValue(input);

            switch (inputNumber)
            {
                case 1:
                    return new EnglishProviderFactory();

                case 2:
                    return new GermanProviderFactory();

                case 3:
                    return new FrenchProviderFactory();

                default:
                    return null;
            }
        }
    }
}
