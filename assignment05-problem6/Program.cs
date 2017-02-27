using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment05_problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                6. Write an application that will enable a vendor to see what earnings he can expect
                to make based on what percentage he marks up an item. Allow the user to input
                the wholesale item price. In a tabular form, show the retail price of the item
                marked up at 5%, 6%, 7%, 8%, 9% and 10%.
             */
            
            const double sixPercent = 1.06;
            const double sevenPercent = 1.07;
            const double eightPercent = 1.08;
            const double ninePercent = 1.09;
            const double tenPercent = 1.1;

            bool keepGoing = true;
            string item;
            double itemCost;

            while(keepGoing)
            {
                Console.WriteLine("How much does this item cost? ");
                item = Console.ReadLine();

                itemCost = double.Parse(item);

                Console.WriteLine("6%\t7%\t8%\t9%\t10%");
                Console.WriteLine((itemCost * sixPercent).ToString("c") + "\t" 
                    + (itemCost * sevenPercent).ToString("c") + "\t"
                    + (itemCost * eightPercent).ToString("c") + "\t"
                    + (itemCost * ninePercent).ToString("c") + "\t"
                    + (itemCost * tenPercent).ToString("c"));
                Console.WriteLine("Continue ( n or N to exit ): ?");
                string decision = Console.ReadLine();
                if (decision == "n" || decision == "N")
                    keepGoing = false; 
            }
        }
    }
}
