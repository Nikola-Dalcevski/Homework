using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 01
            // BIGGER NUMBER;
            Console.WriteLine("--------Exercise 01 Bigger Number----------");
            Console.WriteLine("Enter first number");
            var firstNumber = Console.ReadLine();
            bool firstResult = int.TryParse(firstNumber, out int first);
            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstNumber}' which is invalid number");
            }
            Console.WriteLine("Enter second number");
            var secondNumber = Console.ReadLine();
            bool secondResult = int.TryParse(secondNumber, out int second);
            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondNumber}' which is invalid number");
            }

            int biggerNumber = (first > second) ? first : second;
            string isPositive = (biggerNumber > 0) ? "positive" : "negative";
            bool isEven = biggerNumber % 2 == 0;
            string oddEven = isEven ? "even" : "odd";



            if (first == second && first != 0)
            {
                Console.WriteLine($"Numbers {first} and {second} are equal they are {oddEven} and {isPositive} numbers.");
            }
            else if (first == second && first == 0)
            {
                Console.WriteLine($"Numbers are equal and both od them are zero");
            }
            else if (first != second && biggerNumber != 0)
            {
                Console.WriteLine($"Between {first} and {second} the bigger is {biggerNumber}, which is {oddEven} and {isPositive} number");
            }
            else
            {
                Console.WriteLine($"Between {first} and {second} the bigger is {biggerNumber}");
            };


            //EXERCISE 02
            //SWITCH

            Console.WriteLine("------Exercise 02 Switch-------");
        start:
            Console.WriteLine("Plese eneter your choise 1, 2 or 3");
            var choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    Console.WriteLine("You gog a new car!");
                    break;
                case "2":
                    Console.WriteLine("You gor a new plane!");
                    break;
                case "3":
                    Console.WriteLine("You gor a new bike!");
                    break;
                default:
                    Console.WriteLine($"You entered ivalid choise plese try again ");
                    goto start;
            }


            Console.ReadKey();

        }
    }
}
