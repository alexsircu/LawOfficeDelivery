using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.Models;
using TranslationBE.TranslationProducts;

namespace TranslationBE.TranslationTexts
{
    public class TranslationTextOrder : TranslationTextRequest
    {
        internal Order Order { get; set; }
        internal bool isReady;
        internal bool inPreparation;
        internal int PreperationTime { get; }

        internal TranslationTextOrder(Order order)
        {
            Order = order;
        }
        internal TranslationTextOrder()
        {

        }
    }
}
