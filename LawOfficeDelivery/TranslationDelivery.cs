using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Abstract;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class TranslationDelivery : Delivery, ITranslationProviderFactory
    {
        public TranslationDelivery(string name) : base(name)
        {

        }

        public override void AddProvider(Provider provider)
        {
            TranslationProvider translationProvider = (TranslationProvider)provider;
            Providers.Add(translationProvider); 
        }

        public void Order()
        {

        }
    }
}
