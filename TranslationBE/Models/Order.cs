using CommonBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.TranslationProviders;
using TranslationBE.TranslationTexts;

namespace TranslationBE.Models
{
    public class Order : BaseEntity
    {
        int orderId;
        public bool isReady;
        public int OrderId { get { return orderId; } }
        public readonly List<TranslationTextOrder> textItems;
        internal bool InPreparation;
        internal TranslationProvider translationProvider;
        public TranslationProvider TranslationProvider { get { return translationProvider; } }

        public Order()
        {
            orderId = random.Next(100, 999);
            textItems = new();
        }
    }
}
