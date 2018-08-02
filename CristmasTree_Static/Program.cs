using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristmasTree_Static
{
    class Program
    {
        public static void drawHowManyChars(int HowMany, char Chars)
        {
            int height, space, star;
            for (height = 1; height <= HowMany; height += 1)
            {
                for (space = 1; space <= HowMany - height; space += 1)
                {
                    Console.Write(" ");
                }
                for (star = 1; star <= height * 2 - 1; star += 1)
                {
                    Console.Write(Chars);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            drawHowManyChars(9, '*');
        }
    }
}
