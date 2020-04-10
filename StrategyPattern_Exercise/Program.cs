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

            switch (input)
            {
                case "1":
                    selectPattern.Select(new HorizontalLines());
                    break;

                case "2":
                    selectPattern.Select(new VerticallLines());

                    break;

                default:
                    Console.WriteLine("Not appropriate selection");
                    break;
            }

            
        }
    }
}
