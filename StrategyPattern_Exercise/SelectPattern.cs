using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    class SelectPattern
    {
        protected Pattern Pattern { get; set; }

        protected void Select(Pattern pattern)
        {
            this.Pattern = pattern;
        }
         
        protected void Display()
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

        public void SelectMenu()
        {
            Console.Write("How would you like to cut the field? 1) Horizontal, 2) Vertical : ");
            string input = Console.ReadLine().Trim();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    Select(new HorizontalLines());
                    Display();
                    break;

                case "2":
                    Select(new VerticallLines());
                    Display();
                    break;

                default:
                    Console.WriteLine("Not appropriate selection");
                    Display();
                    break;
            }

            Console.WriteLine();
        }
        
    }
}
