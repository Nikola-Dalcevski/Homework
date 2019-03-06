using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 substring
            Console.WriteLine("---------exercise 1 substring-----------");
            start:
            Console.WriteLine("enter number");
            string text = "Hello from SEDC Codecademy v7.0";
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if(!isNumber)
                {
                Console.WriteLine("You entered invalid nuber please try againg!");
                goto start;
                }
            else if(number > text.Length)
                {
                Console.WriteLine($"Your number is too big the largest namber is {text.Length - 1}!");
                goto start;
                }
            else if(number <= 0)
                {
                Console.WriteLine("You must enter number that is greater form zero!");
                goto start;
                }

            string first = text.Substring(0, number);
            string second = text.Substring(number);

            Console.WriteLine($"'{first}' and '{second}'");
            Console.ReadKey();


            
        }
    }
}
