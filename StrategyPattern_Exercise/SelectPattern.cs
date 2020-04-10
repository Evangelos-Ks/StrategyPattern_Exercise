using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class SelectPattern
    {
        public void Select(Pattern pattern)
        {
            Console.WriteLine();
            Console.WriteLine("\t" + pattern.Name);
            Console.WriteLine();
            pattern.DisplayPattern();
            Console.WriteLine();
        }
    }
}
