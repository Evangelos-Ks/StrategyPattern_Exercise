using System;


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
