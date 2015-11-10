using ConsoleExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDemo();
            MenuDemo();
            Console.ReadKey(true);
        }

        static void SimpleDemo()
        {
            Console.WriteLine("Simple Demo -------------------");
            Console.Write("Please input an integer number: ");
            int value = 0;
            if (!ConsoleInput.TryRead(out value))
            {
                Console.WriteLine("An invalid value was entered");
            }
            else
            {
                Console.WriteLine("You entered a value of " + value);
            }
            Console.WriteLine(new string('-', 50));
        }

        static void MenuDemo()
        {
            Console.WriteLine("Menu Demo --------------------");
            Console.WriteLine("[1] Account Balance");
            Console.WriteLine("[2] Deposit Money");
            Console.WriteLine("[3] Withdraw Money");
            Console.WriteLine("[4] Quit");

            int choice = -1;

            Console.Write("Enter your choice: ");
            while (!ConsoleInput.TryRead(out choice) || (choice <= 0 || choice > 4))
            {
                Console.WriteLine("You entered an invalid choice, please choose between 1 and 4");
                Console.Write("Enter your choice: ");
            }

            Console.WriteLine("You entered a valid value of " + choice);
            Console.WriteLine(new string('-', 50));
        }
    }
}
