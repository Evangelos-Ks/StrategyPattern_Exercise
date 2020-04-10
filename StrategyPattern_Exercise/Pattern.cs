using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Exercise
{
    abstract class Pattern
    {
        protected string[,] field = new string[10, 5];
        abstract public string Name { get; }
        abstract protected string[,] FieldPattern();
        abstract public void DisplayPattern();
    }

    class HorizontalLines : Pattern
    {
        public override string Name => "Horizontal lines";

        protected override string[,] FieldPattern()
        {
            field[0, 0] = "\u2192";
            field[1, 0] = "\u2192";
            field[2, 0] = "\u2192";
            field[3, 0] = "\u2192";
            field[4, 0] = "\u2192";
            field[5, 0] = "\u2192";
            field[6, 0] = "\u2192";
            field[7, 0] = "\u2192";
            field[8, 0] = "\u2192";
            field[9, 0] = "\u2193";

            field[0, 1] = "\u2193";
            field[1, 1] = "\u2190";
            field[2, 1] = "\u2190";
            field[3, 1] = "\u2190";
            field[4, 1] = "\u2190";
            field[5, 1] = "\u2190";
            field[6, 1] = "\u2190";
            field[7, 1] = "\u2190";
            field[8, 1] = "\u2190";
            field[9, 1] = "\u2190";

            field[0, 2] = "\u2192";
            field[1, 2] = "\u2192";
            field[2, 2] = "\u2192";
            field[3, 2] = "\u2192";
            field[4, 2] = "\u2192";
            field[5, 2] = "\u2192";
            field[6, 2] = "\u2192";
            field[7, 2] = "\u2192";
            field[8, 2] = "\u2192";
            field[9, 2] = "\u2193";

            field[0, 3] = "\u2193";
            field[1, 3] = "\u2190";
            field[2, 3] = "\u2190";
            field[3, 3] = "\u2190";
            field[4, 3] = "\u2190";
            field[5, 3] = "\u2190";
            field[6, 3] = "\u2190";
            field[7, 3] = "\u2190";
            field[8, 3] = "\u2190";
            field[9, 3] = "\u2190";

            field[0, 4] = "\u2192";
            field[1, 4] = "\u2192";
            field[2, 4] = "\u2192";
            field[3, 4] = "\u2192";
            field[4, 4] = "\u2192";
            field[5, 4] = "\u2192";
            field[6, 4] = "\u2192";
            field[7, 4] = "\u2192";
            field[8, 4] = "\u2192";
            field[9, 4] = "\u2192";

            return field;
        }

        public override void DisplayPattern()
        {
            int columns = field.GetLength(0);
            int rows = field.GetLength(1);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" -----------------------------------------");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(FieldPattern()[column, row]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(" | ");
                Console.WriteLine(" -----------------------------------------");
            }
        }
    }

    class VerticallLines : Pattern
    {
        public override string Name => "Vertical lines";

        protected override string[,] FieldPattern()
        {
            field[0, 0] = "\u2193";
            field[1, 0] = "\u2192";
            field[2, 0] = "\u2193";
            field[3, 0] = "\u2192";
            field[4, 0] = "\u2193";
            field[5, 0] = "\u2192";
            field[6, 0] = "\u2193";
            field[7, 0] = "\u2192";
            field[8, 0] = "\u2193";
            field[9, 0] = "\u2191";

            field[0, 1] = "\u2193";
            field[1, 1] = "\u2191";
            field[2, 1] = "\u2193";
            field[3, 1] = "\u2191";
            field[4, 1] = "\u2193";
            field[5, 1] = "\u2191";
            field[6, 1] = "\u2193";
            field[7, 1] = "\u2191";
            field[8, 1] = "\u2193";
            field[9, 1] = "\u2191";

            field[0, 2] = "\u2193";
            field[1, 2] = "\u2191";
            field[2, 2] = "\u2193";
            field[3, 2] = "\u2191";
            field[4, 2] = "\u2193";
            field[5, 2] = "\u2191";
            field[6, 2] = "\u2193";
            field[7, 2] = "\u2191";
            field[8, 2] = "\u2193";
            field[9, 2] = "\u2191";

            field[0, 3] = "\u2193";
            field[1, 3] = "\u2191";
            field[2, 3] = "\u2193";
            field[3, 3] = "\u2191";
            field[4, 3] = "\u2193";
            field[5, 3] = "\u2191";
            field[6, 3] = "\u2193";
            field[7, 3] = "\u2191";
            field[8, 3] = "\u2193";
            field[9, 3] = "\u2191";

            field[0, 4] = "\u2192";
            field[1, 4] = "\u2191";
            field[2, 4] = "\u2192";
            field[3, 4] = "\u2191";
            field[4, 4] = "\u2192";
            field[5, 4] = "\u2191";
            field[6, 4] = "\u2192";
            field[7, 4] = "\u2191";
            field[8, 4] = "\u2192";
            field[9, 4] = "\u2191";

            return field;
        }

        public override void DisplayPattern()
        {
            int columns = field.GetLength(0);
            int rows = field.GetLength(1);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" -----------------------------------------");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(FieldPattern()[column, row]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(" | ");
                Console.WriteLine(" -----------------------------------------");
            }
        }
    }



}
