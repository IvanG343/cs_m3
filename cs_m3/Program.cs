using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m3 {
    internal class Task1 {
        static void Main(string[] args) {

            #region Task 1

            Console.Write("Пожалуйста введите число: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0) {
                Console.WriteLine($"Число {a} четное");
            } else {
                Console.WriteLine($"Число {a} не чётное");
            }

            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region Task 2

            int cardSum = 0;

            Console.WriteLine("Приветсвтвуем в нашем казино!");
            Console.Write("Укажите количество карт у вас на руках: ");
            int cardCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cardCount;) {
                Console.Write($"Введите номинал {i} карты (используйте значение J, Q, K и T для картинок): ");
                string value = Console.ReadLine();
                bool isInteger = int.TryParse(value, out int num);

                if (isInteger && num >= 2 && num <= 10) {
                    cardSum += num;
                    i++;
                } else {
                    switch (value) {
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

            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region Task 3

            bool isComposite = false;
            bool isNum;
            int counter = 2;
            int number;

            do {
                Console.Write("Введите число больше единцы: ");
                isNum = int.TryParse(Console.ReadLine(), out number);
                if (!isNum || number <= 1) {
                    Console.WriteLine("Вы ввели неверное число!\n");
                }
            } while (!isNum || number <= 1);

            while (counter < number) {
                if (number % counter == 0) {
                    isComposite = true;
                    break;
                }
                counter++;
            }

            Console.WriteLine(isComposite ? $"Число {number} не является простым числом" : $"{number} простое число");
            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region Task 4

            int min = int.MaxValue;
            bool lengthIsNumber;
            int length;

            do {
                Console.Write("Укажите длинну последовательности: ");
                lengthIsNumber = int.TryParse(Console.ReadLine(), out length);
                if (!lengthIsNumber || length < 0) {
                    Console.WriteLine("Вы ввели неверное число!\n");
                }
            } while (!lengthIsNumber || length < 0);

            for(int i = 1; i <= length; i++) {
                Console.Write($"Введите {i} число и нажмите Enter: ");
                int currentNum = int.Parse(Console.ReadLine());
                if(min > currentNum) {
                    min = currentNum;
                }
            }

            Console.WriteLine($"Наименьшее число в последовательности: {min}");
            Console.ReadKey();

            #endregion


        }
    }
}
