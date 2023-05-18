using System;
using System.Globalization;

namespace LawOfficeDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAZIONE PROVIDERS COME SINGLETON E LASCIATO IN MANO AGLI OFFICE? NO NON HA SENSO


            //PROVIDERS CREATION
            FoodProvider starbucks = new FoodProvider("Starbucks", "7:30", "19:00", 3);
            FoodProvider mcdonalds = new FoodProvider("McDonald's", "12:00", "00:00", 67);
            FoodProvider asdf = new FoodProvider("asdf", "12:00", "00:00", 54);
            FoodProvider asdfasdfsadf = new FoodProvider("asdfasfd", "12:00", "00:00", 7);
            TranslationProvider translationProvider = new TranslationProvider("Translation Provider", "9:00", "18:00", 13);

            //DELIVERIES CREATION
            FoodDelivery foodDelivery = new FoodDelivery("Food Delivery");
            TranslationDelivery translationDelivery = new TranslationDelivery("Translation Delivery");

            //PROVIDERS ADD
            foodDelivery.AddProvider(starbucks);
            foodDelivery.AddProvider(mcdonalds);
            foodDelivery.AddProvider(asdf);
            foodDelivery.AddProvider(asdfasdfsadf);
            translationDelivery.AddProvider(translationProvider);

            //OFFICE CREATION
            LawOffice office = new LawOffice(foodDelivery, translationDelivery);
            char input;
            

            do
            {
                Console.Write("Per ordinare del cibo premi 'C', per effettuare una traduzione premi 'T' : ");
                //Console.WriteLine("");

                input = char.ToUpper(Console.ReadKey().KeyChar);
                office.OfficeManagerProp.Order(input);
                /*Console.WriteLine("");
                Console.WriteLine("------------------");
                streamingPlatform.ListSongs();

                Console.WriteLine("------------------");
                Console.WriteLine("select Song number: ");
                input = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine();
                if (input == 'E')
                    return;

                var inputNumber = CharUnicodeInfo.GetDecimalDigitValue(input);

                if (Utility.CheckInput(streamingPlatform.totalTacks, inputNumber))
                {
                    streamingPlatform.Play(inputNumber - 1);
                }
                Console.WriteLine("------------------");
                Console.WriteLine("");*/
            } while (input != '1');

            /*do
            {
                Console.WriteLine("Next  press F: ");
                Console.WriteLine("Previous  press B: ");
                Console.WriteLine("Pause  Press P: ");
                Console.WriteLine("Stop  Press S: ");

                Console.WriteLine("--------------------------");
                Console.WriteLine("For Exit press E: ");

                input = char.ToUpper(Console.ReadKey().KeyChar);
                if (input == 'E')
                    return;

                Console.WriteLine();

                switch (input)
                {
                    case 'F':
                        streamingPlatform.Forward();
                        break;

                    case 'B':
                        streamingPlatform.Backward();
                        break;

                    case 'S':
                        streamingPlatform.Stop();
                        break;

                    case 'P':
                        streamingPlatform.Pause();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Scelta non valida!");
                        Console.ResetColor();
                        break;
                }

                
            } while (input != 'E'); */
        }
    }
}
