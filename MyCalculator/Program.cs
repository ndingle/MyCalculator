using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        static void division()
        {
            Console.Write("Enter a numb: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another numb: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Yours numbers divided are: {n1 / n2}");
        }

        static void times()
        {
            Console.Write("Enter a numb: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another numb: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Yours numbers timesd are: {n1 * n2}");
        }
        static void subtract()
        {
            Console.Write("Enter a numb: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another numb: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Yours numbers subtracted are: {n1 + n2}");
        }
        static void add()
        {
            Console.Write("Enter a numb: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another numb: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Yours numbers added are: {n1+n2}");
        }
        static void Menu()
        {
            string selection = "";
            while (true)
            {
                Console.WriteLine("Welcome to the world greetest calculator.");
                Console.WriteLine("");
                Console.WriteLine(" (A) Add");
                Console.WriteLine(" (B) Subtract");
                Console.WriteLine(" (C) Times");
                Console.WriteLine(" (C) Divide");
                Console.WriteLine("");



                Console.WriteLine(" (X) Exit");

                selection = Console.ReadLine();
                if (selection == "A") add();
                if (selection == "A") subtract();
                if (selection == "C") times();
                if (selection == "D") division();
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
