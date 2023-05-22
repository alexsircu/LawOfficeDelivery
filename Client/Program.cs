using System;
using System.Globalization;
using System.Threading.Tasks;
using Middleware;
using FoodBE.Models;

namespace Client
{
    internal class Program
    {
        static double distance = 2.0;
        static char input;
        static Services services;
        static FoodUI foodUI;
        //static TranslationUI translationUI;
        static Action<string, Order> feedback;

        static async Task Main(string[] args)
        {
            do
            {
                Console.Clear();
                // FoodUI.getAllThresds();
                do
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("SMART OFFICE OPERATIONS");
                    Console.WriteLine("SELECT: ");
                    Console.WriteLine("   1.Food");
                    Console.WriteLine("   2.Translation");
                    Console.WriteLine("   Q.Quit");

                    input = char.ToUpper(Console.ReadKey().KeyChar);

                } while (input != 'Q' && input != '1' && input != '2');

                if (input == 'Q') return;
                int inputNumber = CharUnicodeInfo.GetDecimalDigitValue(input);
                Console.Clear();

                switch (inputNumber)
                {
                    case 1:
                        services = new FoodServices();
                        foodUI = new((FoodServices)services, distance);
                        feedback = foodUI.Notify;
                        foodUI.Start(ref input);

                        do
                        {
                            switch (input)
                            {
                                case 'B':
                                    foodUI.ShowBasket(ref input);
                                    break;
                                case 'R':
                                    foodUI.ShowMenu(ref input);
                                    break;
                                case 'S':
                                    await foodUI.SendOrder(feedback);
                                    input = 'E';
                                    break;
                                case 'E':
                                    input = 'Q';
                                    break;
                                case 'Q':
                                    return;
                                default:
                                    foodUI.ShowMenu(ref input);
                                    break;
                            }
                            Console.ResetColor();

                        } while (input != 'Q');
                        break;

                    case 2:
                        /*services = new TranslationServices();
                        translationUI = new((TranslationServices)services);
                        feedback = translationUI.Notify;
                        translationUI.Start(ref input, feedback);

                        do
                        {
                            switch (input)
                            {
                                case 'E':
                                    input = 'Q';
                                    break;
                                case 'Q':
                                    return;
                            }
                            Console.ResetColor();

                        } while (input != 'Q');*/
                        break;
                }
                Console.ResetColor();

                if (input == 'E') return;

            } while (input != 'E');
        }
    }
}
