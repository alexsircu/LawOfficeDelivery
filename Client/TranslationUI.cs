/*using Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using TranslationBE.TranslationProducts;
using TranslationBE.Models;

namespace Client
{
    public class TranslationUI
    {
        TranslationServices _translationServices;
        IReadOnlyList<TranslationTextRequest> _menu;
        double _distance;

        public TranslationUI(TranslationServices translationServices)
        {
            _translationServices = translationServices;
        }

        public void Start(ref char input, Action<string, Order> FeedBack)
        {
            _translationServices.Start(ref input);
            ShowMenuTypes(ref input);
            SendOrder(FeedBack);
            if (input == 'Q') return;
            _translationServices.GetProvider(_distance);
        }
        private void ShowMenuTypes(ref char input)
        {
            int inputNumber;

            do
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Choose language:");
                Console.WriteLine("     1.English:");
                Console.WriteLine("     2.German:");
                Console.WriteLine("     3.French:");
                Console.WriteLine();
                Console.WriteLine("   Q. for quit ");
                input = char.ToUpper(Console.ReadKey().KeyChar);
                if (input == 'Q') return;
                inputNumber = CharUnicodeInfo.GetDecimalDigitValue(input);

            } while (inputNumber != 1 && inputNumber != 2 && inputNumber != 3);


            _translationServices.CreateProviderFactory(ref input);
        }
        public void Notify(string msg, Order order)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(msg);
            Console.ResetColor();
            foreach (var item in order.foodItems) 
            {
                Console.WriteLine($"    {item.Name}");
            }
            Thread.Sleep(2000);
        }
        public static void GetAllThresds()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("ThreadPool PendingWorkItemCount:");
            Console.Write(ThreadPool.PendingWorkItemCount);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("ThreadPool ThreadCount :");
            Console.Write(ThreadPool.ThreadCount);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("ThreadPool CompletedWorkItemCount  :");
            Console.Write(ThreadPool.CompletedWorkItemCount);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
        }
        public async Task<char> SendOrder(Action<string, Order> FeedBack)
        {
            Console.Clear();

            await Task.Run(async () =>
            {
                Console.WriteLine("Sending Order... ");
                await Task.Delay(2000);

                OrderResponseTranslation response = await _translationServices.SendOrder();
                if (response.Order is not null)
                {
                    Console.WriteLine("\n\n\n");
                    FeedBack("You Order is Here!! ", response.Order);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("There's was an error with your Order. Please, Try again!");
                    Console.WriteLine(response.Error);
                    Console.WriteLine(response.Error);
                    Console.WriteLine();
                    Console.ResetColor();
                }
            });

            return 'Q';
        }
    }
}
*/