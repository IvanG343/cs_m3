using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m3 {
    internal class Program {
        static void Main(string[] args) {

            #region Task 1

            //Console.Write("Пожалуйста введите число: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0) {
            //    Console.WriteLine($"Число {a} четное");
            //} else {
            //    Console.WriteLine($"Число {a} не чётное");
            //}

            //Console.WriteLine();
            //Console.ReadKey();

            #endregion

            #region Task 2

            int cardSum = 0;

            Console.WriteLine("\nПриветсвтвуем в нашем казино!");
            Console.Write($"Укажите количество карт у вас на руках: ");
            int cardCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cardCount;) {
                Console.Write($"Введите номинал {i} карты (используйте значение J, Q, K и T для картинок): ");
                string value = Console.ReadLine();
                bool isInteger = int.TryParse(value, out int num);

                if (isInteger && num >= 2 && num <= 10) {
                    cardSum += num;
                    i++;
                } else {
                    switch(value) {
                        case "J":
                        case "j":
                        case "Q":
                        case "q":
                        case "K":
                        case "k":
                        case "T":
                        case "t":
                            cardSum += 10;
                            i++;
                            break;
                        default:
                            Console.WriteLine("Указан неверный номинал карты");
                            break;
                    }
                }
            }

            Console.WriteLine($"Вы набрали {cardSum} очков!");

            Console.ReadKey();

            #endregion

        }
    }
}
