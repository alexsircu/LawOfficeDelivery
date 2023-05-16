using System;
using System.Globalization;

namespace LawOfficeDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Per ordinare del cibo premi 'C', per effettuare una traduzione premi 'T' : ");
            //Console.WriteLine("");

            var input = char.ToUpper(Console.ReadKey().KeyChar);


            //creazione foodprovider
            //creazione translationprovider
            //aggiunta providers all'office
            LawOffice office = new LawOffice();
            


            if (input == 'C')
            {
                //streamingPlatform = new Spotify();
            }
            else
            {
                streamingPlatform = new Netflix();
            }
            do
            {
                Console.WriteLine("");
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
                Console.WriteLine("");
            } while (!streamingPlatform.isPlaying);
            do
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


            } while (input != 'E');
        }
    }
    }
}
