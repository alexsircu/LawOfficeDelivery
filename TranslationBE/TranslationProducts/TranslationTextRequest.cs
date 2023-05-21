using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBE;

namespace TranslationBE.TranslationProducts
{
    public class TranslationTextRequest : BaseEntity 
    {
        protected string name;
        protected decimal price;
        protected int translationCode;
        public int FoodCode { get { return translationCode; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        public TranslationTextRequest(int code)
        {
            translationCode = code;
        }
        public TranslationTextRequest()
        {
        }
    }
}
