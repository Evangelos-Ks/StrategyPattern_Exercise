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

            selectPattern.SelectMenu();
            
            Console.ReadKey();
        }
    }
}
