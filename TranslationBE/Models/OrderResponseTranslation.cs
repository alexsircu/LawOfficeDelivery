using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationBE.Models
{
    public class OrderResponseTranslation
    {
        public Order Order { get; internal set; }
        public string Error { get; internal set; }
    }
}
