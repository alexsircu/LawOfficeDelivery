using TranslationBE.DesignPattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class TranslationServices : Services
    {
        static IAbstractTranslationServiceFactory ServiceFactory;
        static ITranslationProviderFactory ProviderFactory;
        static ITranslationTextProvider TranslationProvider;
        public void Start(ref char input)
        {
            ServiceFactory = ClientServicesFactory.CreateServiceFactory(ref input);
        }

        public void GetProvider(double distance)
        {
            TranslationProvider = ProviderFactory.CreateTranslationTextProvider(distance);
        }
    }
}
