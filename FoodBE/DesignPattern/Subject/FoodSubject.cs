using FoodBE.DesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodBE.FoodProviders;

namespace FoodBE.DesignPattern.Subject
{
    public abstract class FoodSubject : Subject<FoodProvider>
    {
        protected override List<FoodProvider> observers { get; set; }

        public void GetMenu()
        {
            foreach (IFoodObserver o in observers)
            {
                // - Quando viene richeisto il menu, Viene notificato a tutti gli Observers che fanno dei calcoli 
                //    in base al numero di ordini e distanza risponderà il provider piu appropriato.

                o.GetMenu();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
        }
        public FoodSubject(string Name) : base(Name)
        {

        }
        public FoodSubject()
        {

        }
    }
}
