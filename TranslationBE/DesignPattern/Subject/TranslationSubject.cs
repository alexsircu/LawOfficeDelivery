using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationBE.TranslationProviders;
using CommonBE.DesignPattern;
using TranslationBE.DesignPattern.Observer;

namespace TranslationBE.DesignPattern.Subject
{
    public abstract class TranslationSubject : Subject<TranslationProvider>
    {
        protected override List<TranslationProvider> observers { get; set; }

        public void GetMenu()
        {
            foreach (ITranslationTextObserver o in observers)
            {
                // - Quando viene richeisto il menu, Viene notificato a tutti gli Observers che fanno dei calcoli 
                //    in base al numero di ordini e distanza risponderà il provider piu appropriato.

                o.GetOperators();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
        }
        public TranslationSubject(string Name) : base(Name)
        {

        }
        public TranslationSubject()
        {

        }
    }
}
