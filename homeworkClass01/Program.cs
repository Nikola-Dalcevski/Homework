using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass01
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("                     *");
            Console.WriteLine("                     *");
            Console.WriteLine("                   * * *");
            Console.WriteLine("                     *");
            Console.WriteLine("                 * * * * *");
            Console.WriteLine("                     *");
            Console.WriteLine("               * * * * * * *");
            Console.WriteLine("                     *");
            Console.WriteLine("             * * * * * * * * *");
            Console.WriteLine("                     *");
            Console.WriteLine("           * * * * * * * * * * *");
            Console.WriteLine("                     *");
            Console.WriteLine("         * * * * * * * * * * * * *");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                     *");
            Console.WriteLine("                     *");
            Console.WriteLine("                     *");
            Console.ForegroundColor = color;
            Console.WriteLine("***************************************************");





            int space = 9;
            int star = 1;
            int end = 10;
            for (int i = 0; i < end; i++)
            {

                if (i < end - 3)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    for (int j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < star; k++)
                    {
                        Console.Write("* ");
                    }

                }
                else
                {


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("         *");


                }
                Console.WriteLine("");
                star++;
                space--;
            }

            Console.ForegroundColor = color;
            Console.WriteLine("------------------------------");
            Console.ReadKey();

        }
    }
}
