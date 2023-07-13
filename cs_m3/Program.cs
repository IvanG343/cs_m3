using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m3 {
    internal class Program {
        static void Main(string[] args) {

            #region Task 1

            Console.Write("Please enter a number: ");
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0) {
                Console.WriteLine($"Число {a} четное");
            } else {
                Console.WriteLine($"Число {a} не чётное");
            }

            Console.ReadKey();

            #endregion

        }
    }
}
