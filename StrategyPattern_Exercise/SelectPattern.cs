using System;

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

        protected void ChoosePattern(string selectedPattern)
        {
            switch (selectedPattern)
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
        }

        public void SelectMenu()
        {
            Console.WriteLine("\tHow would you like to cut the field?");
            Console.WriteLine();
            Console.WriteLine("\t1. Horizontal");
            Console.WriteLine("\t2. Vertical");
            Console.WriteLine();
            Console.Write("\tSelect the appropriate number : ");
            string selectedPattern = Console.ReadLine().Trim();
            Console.WriteLine();

            ChoosePattern(selectedPattern);

            Console.WriteLine();
        }
    }
}
