using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectPattern selectPattern = new SelectPattern();

            Console.Write("How would you like to cut the field? 1) Horizontal, 2) Vertical : ");
            string input = Console.ReadLine().Trim();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    selectPattern.Select(new HorizontalLines());
                    selectPattern.Display();
                    break;

                case "2":
                    selectPattern.Select(new VerticallLines());
                    selectPattern.Display();
                    break;

                default:
                    Console.WriteLine("Not appropriate selection");
                    selectPattern.Display();
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
