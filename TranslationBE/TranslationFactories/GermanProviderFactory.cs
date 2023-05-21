using CommonBE.DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.DesignPattern.AbstractFactory;
using TranslationBE.TranslationProviders;
using TranslationBE.Utilities;

namespace TranslationBE.TranslationFactories
{
    public class GermanProviderFactory : TranslationProviderFactory
    {
        public GermanProviderFactory() 
        {
            string[] args = { "German1 ", "German2", "German3", "German4", "German5" };
            observers.Cast<GermanProvider>(); // Lista vuota  
            TranslationUtility.CreateTranslationProviders<GermanProvider>(this, args); // Fill observers list 
            TranslationUtility.CreateFakeOrders(observers);
        }
        public override ITranslationTextFactory CreateTranslationTextProvider(double Distance)
        {
            GermanProvider germanProvider = observers.OrderByDescending(x => x.WaitingTime).First();
            return germanProvider;
        }
    }
}
