using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class SelectPattern
    {
        public Pattern Pattern { get; set; }

        public void Select(Pattern pattern)
        {
            this.Pattern = pattern;
        }
         
        public void Display()
        {
            if (Pattern != null)
            {
                Console.WriteLine();
                Console.WriteLine("\t" + Pattern.Name);
                Console.WriteLine();
                Pattern.DisplayPattern();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You didn't choose a pattern");
            }
            
        }
        
    }
}
