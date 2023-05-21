using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.TranslationProducts;

namespace TranslationBE.Models
{
    public class Basket
    {
        public List<TranslationTextRequest> translationTextOrder;
        public Basket()
        {
            translationTextOrder = new();
        }
    }
}


