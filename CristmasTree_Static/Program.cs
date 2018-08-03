using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristmasTree_Static
{
    class Program
    {
        public static void drawHowManyChars1(int HowMany, char Chars) //方法1
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
        public static void drawHowManyChars2(int HowMany, char Chars) //方法2
        {
            for (int i = 1; i <= HowMany; i += 1)
            {
                Console.Write(Chars);
            }
        }
        static void Main(string[] args)
        {
            //呼叫方法1
            {
                Console.WriteLine("Call Method 1\n");
                Program.drawHowManyChars1(5, '*');
                Console.WriteLine();
            }
            //呼叫方法2
            { 
            int height = 5;
            int space = height - 1;
            int star = 1;

                Console.WriteLine("Call Method 2\n");
                for (int i = 1; i <= 5; i++)
                {
                    Program.drawHowManyChars2(space, ' ');
                    Program.drawHowManyChars2(star, '*');
                    Program.drawHowManyChars2(1, '\n');

                    space -= 1;
                    star += 2;
                }
                Console.WriteLine();
            }
        }
    }
}
