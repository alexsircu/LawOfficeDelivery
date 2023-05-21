using Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using FoodBE.Models;
using System.Threading;
using TranslationBE.TranslationProducts;

namespace Client
{
    public class TranslationUI
    {
        TranslationServices _translationServices;
        IReadOnlyList<TranslationTextRequest> _menu;
        double _distance;

        public TranslationUI(TranslationServices translationServices, double distance)
        {
            _translationServices = translationServices;
            _distance = distance;
        }

        public void Start(ref char input)
        {
            _translationServices.Start(ref input);
            ShowMenuTypes(ref input);
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
        public void ShowBasket(ref char input)
        {
            Console.Clear();

            var items = _translationServices.Basket.foodProductOrder
           .GroupBy(e => e.FoodCode)
           .ToDictionary(fp =>
           fp.Key,
           fp => fp.ToArray());

            string Values = string.Empty;
            decimal Price;
            string Name;
            int Amount;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MY BASKET\n\n");
            Console.ResetColor();
            Console.WriteLine("-------------------------------");

            foreach (int item in items.Keys)
            {

                Price = items[item].Sum(i => i.Price);
                Amount = items[item].Count();
                Name = items[item].FirstOrDefault().Name;

                // Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{Name.ToUpper()}");
                Console.ResetColor();
                //Console.WriteLine($"    CODE: {item} ");
                Console.WriteLine($"    PIECES: {Amount} ");
                Console.WriteLine($"    PRICE AMOUNT: $.{Price} ");
                Console.WriteLine("-------------------------------");
            }
            do
            {

                Console.WriteLine();
                Console.WriteLine();
                ShowTotPrice();

                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine(" R. Return to Menu ");
                input = char.ToUpper(Console.ReadKey().KeyChar);



            } while (input != 'R');
            return;

        }
        public void ShowTotPrice()
        {
            decimal tot = _translationServices.Basket.foodProductOrder.Sum(i => i.Price);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"PRICE AMOUNT to PAY : $. {tot} ");
            Console.WriteLine();
            Console.ResetColor();


        }
        public void ShowMenu(ref char input)
        {

            string OperatorInput = null;
            Console.Clear();
            GetAllThresds();
            _menu = _translationServices.GetMenu(); //get operators

            do
            {
                Console.Clear();
                do
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Operators from {_translationServices.FoodProvider.Name}:".ToUpper());
                    Console.ResetColor();

                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"SELECT OPERATOR ");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------");

                    foreach (var item in _menu)
                    {
                        Console.Write($"{item.FoodCode}");
                        Console.Write(" | ");
                        Console.Write(item.Name);
                        Console.Write(" | ");
                        Console.Write($"$.{item.Price}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("-------------------------------");

                    ShowTotPrice();

                    Console.WriteLine("Type operator number and press Enter");
                    Console.WriteLine("Q. to quit | B. basket | S. Send order ");
                    Console.Write("INSERT CHOICE:  ");

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    OperatorInput = Console.ReadLine();
                    Console.ResetColor();

                    if (OperatorInput.Length == 1)
                    {
                        input = char.Parse(OperatorInput.ToUpper());
                        return;
                    }

                    Console.WriteLine("-------------------------------");

                } while (AddToBasket(OperatorInput));

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Q. to quit | B. basket | S. Send order ");

            } while (true);
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
        public bool AddToBasket(string operatorItem)
        {
            int inputNumber;
            int.TryParse(operatorItem, out inputNumber);

            TranslationTextRequest item = _menu.Where(i => i.FoodCode == inputNumber).FirstOrDefault();
            if (item is not null)
            {
                _translationServices.AddToBasket(item);
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inserire un elemento valido.");
                Console.Beep();
                Thread.Sleep(2000);
                Console.ResetColor();
                Console.Clear();
                return true;
            }
        }
        public async Task<char> SendOrder(Action<string, Order> FeedBack)
        {
            Console.Clear();

            await Task.Run(async () =>
            {
                Console.WriteLine("Sending Order... ");
                await Task.Delay(2000);

                OrderResponse response = await _translationServices.SendOrder();
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
