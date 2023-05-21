using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.AbstractFactory;
using CommonBE.DesignPattern;
using TranslationBE.DesignPattern.Subject;

namespace TranslationBE.TranslationFactories
{
    public abstract class TranslationProviderFactory : TranslationSubject, ITranslationProviderFactory
    {
        public abstract ITranslationTextFactory CreateTranslationTextProvider(double Distance);

        public TranslationProviderFactory()
        {
        }
    }
}
