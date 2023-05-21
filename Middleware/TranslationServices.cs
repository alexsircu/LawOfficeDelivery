using TranslationBE.DesignPattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.FoodProducts;
using TranslationBE.TranslationProducts;

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

        public void CreateProviderFactory(ref char input)
        {
            ProviderFactory = ServiceFactory.CreateProviderFactory(ref input);
        }
        public List<TranslationTextRequest> GetOperators()
        {
            return TranslationProvider.GetOperators();
        }
    }
}
