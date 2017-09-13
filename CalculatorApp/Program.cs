using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedCalculatorLibrary;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Velkommen til din nye lommeregner --------------");

            Console.WriteLine("Indtast dit første tal...");
            string Tal1 = Console.ReadLine();
            double temp1 = Double.Parse(Tal1);

            Console.WriteLine("Indtast en operator...");
            string Operator = Console.ReadLine();

            Console.WriteLine("Indtast dit andet tal...");
            string Tal2 = Console.ReadLine();
            double temp2 = Double.Parse(Tal2);

            var calc = new BasicOperations(temp1, temp2);
            switch (Operator)
            {
                case "+":
                    Console.WriteLine(calc.PlusFunktion());
                    break;
                case "-":
                    Console.WriteLine(calc.MinusFunktion());
                    break;
                case "*":
                    Console.WriteLine(calc.GangeFunktion());
                    break;
                case "/":
                    Console.WriteLine(calc.DividerFunktion());
                    break;
                default:
                    Console.WriteLine("Indtast venligst en korrekt operator.");
                    break;
            }
        }
    }
}
