using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Exercise 01-------------");
            start:
            Console.WriteLine("Enter a first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int age);
            if(!isNumber)
            {
                Console.WriteLine("You entered invalid age please try again");
                goto start;
            }

            var user = new Human(firstName, lastName, age);
            Console.WriteLine(user.GetPrsonStats());
            Console.ReadKey();


            Console.WriteLine("--------- Exercise 02 ----------");

            Console.WriteLine("Enter Dog name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter dogs race");
            string race = Console.ReadLine();

            Console.WriteLine("Enter dogs color");
            string color = Console.ReadLine();

            var pet = new Dog(name, race, color);

            while (true)
            {
                Console.WriteLine("Choos action for your pet");
                Console.WriteLine("1 - dog eat");
                Console.WriteLine("2 - dog play");
                Console.WriteLine("3 - Dog chais tail");

                var inputChoise = Console.ReadLine();
                bool isNum = int.TryParse(inputChoise, out int choise);
                if (!isNum)
                {
                    Console.WriteLine("You Entered invalid choise please try again");
                    break;
                }

                switch (choise)
                {
                    case 1:
                    Console.WriteLine(pet.isEating());
                    break;

                    case 2:
                    Console.WriteLine("Enter a toy for the dog");
                    var toyinput = Console.ReadLine();
                    Console.WriteLine(pet.isPlaying(toyinput));
                    break;

                    case 3:
                    Console.WriteLine(pet.isChaseTail());
                    break;

                    default:
                    Console.WriteLine("You chois dont exists");
                    break;
                }

                Console.WriteLine("Do you what another action Y/n");
                string another = Console.ReadLine();
                if(another == "no")
                {
                    break;
                }

                
            }

            Console.WriteLine("----------Exercise 03-----------");

           
        }
    }
}
