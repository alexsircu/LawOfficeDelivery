using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TranslationBE.TranslationTexts
{
    public abstract class TranslationText : TranslationTextOrder
    {
        protected string description;
        protected int preperationTime;

        public TranslationText(decimal Price, string Name) : base()
        {
            price = Price;
            name = Name;
            translationCode = random.Next(100, 999);
            MealOfferType = new List<MealType>();
        }
        public TranslationText()
        {
            MealOfferType = new List<MealType>();
        }

        // internal  int PreperationTime { get { return preperationTime; } }
        internal abstract string[] DevivedProducts { get; }
        internal List<MealType> MealOfferType { get; }


        public double GetTime()
        {
            //  Fake time of preparation 
            Thread.Sleep(random.Next(1000, 10000));
            return new TimeSpan(random.Next(60, 3600)).TotalMinutes;
        }
    }
}
