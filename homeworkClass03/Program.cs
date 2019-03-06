using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass03
{
    class Program
    {
        static void Main(string[] args)
        {   //Exercise 5 Arrays
            Console.WriteLine("------Exercise sum all elements of array--------");
            int[] numbers = new int[5];
            start:
            for(int i = 0; i < numbers.Length; i++)
                {

                if (i == 0)
                    {
                    Console.WriteLine("Enter number");
                    }else
                    {
                    Console.WriteLine("Enter next number");
                    }

                  var input = Console.ReadLine();
                  bool isNumber = int.TryParse(input, out int number);

                  if(!isNumber)
                    {
                    Console.WriteLine("You entered invalid number please try agan");
                    goto start;

                    }
                  numbers[i] = number;
                
                } 

             int sum = 0;
            
             foreach(int i in numbers)
                {
                sum = sum + i;
                }

             Console.WriteLine($"The sum of all numbers is {sum}");

            //Exercise 2 Array names
            Console.WriteLine("--------- Exercise 2 Array names -----------");
            
            string[] names = new string[0];

            while(true)
                {
                Array.Resize(ref names, names.Length + 1);

                Console.WriteLine("Enter name");

                names[names.Length -1] = Console.ReadLine();

                Console.WriteLine("Do you whant to enter another name? Y/n");

                string input = Console.ReadLine();

                if(input == "n" || input == "N")
                    {
                    break;   
                    }     
                
                }


            string largestName = "";
            string smallestName = "";
            int allLength = 0;
            
            foreach(var name in names)
                {
                if(largestName.Length < name.Length)
                    {
                    largestName = name;
                    }
                
                if(smallestName == "")
                    {
                    smallestName = name;
                    }
                else if(smallestName.Length > name.Length)
                    {
                    smallestName = name;
                    }
                  allLength += name.Length;
                }
            
            var averige = allLength / names.Length;
            Console.WriteLine($"The largestname is {largestName} and the smallest is {smallestName}");
            Console.WriteLine($"The averige length of the names is {averige}");
             Console.ReadKey();
                
                                                             
        }
    }
}
