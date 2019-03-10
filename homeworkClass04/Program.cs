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


            //Exercise 02 Age Calculator
            Console.WriteLine("-------------Exercise 2 Age calculator------------");
              startt:
             Console.WriteLine("Enter birth year:");
                    var inputYear = Console.ReadLine();
                    bool isNumberYear = int.TryParse(inputYear, out int myYear);
                    Console.WriteLine("Enter birth month:");
                    var inputMonth = Console.ReadLine();
                    bool isNumberMonth = int.TryParse(inputMonth, out int myMonth);
                    Console.WriteLine("Enter birth day:");
                    var inputDay = Console.ReadLine();
                    bool isNumberDay = int.TryParse(inputDay, out int myDay);

                        
                    if(!isNumberYear || inputYear.Length > 4 )
                        {
                        Console.WriteLine("You entered invalid year please try again");
                        goto startt;
                        }
                    else if(!isNumberMonth || inputMonth.Length > 12 || inputMonth.Length < 1)
                        {
                        Console.WriteLine("You entered invalid year please try again");
                         goto startt;
                        }
                    else if(!isNumberDay ||  inputMonth.Length > 31 || inputMonth.Length < 1 )
                        {
                        Console.WriteLine("You entered invalid day please try again");
                         goto startt;
                        }
                  
            
              int AgeCalculator(int year, int month, int day)
                {
                var birthDate = new DateTime(year,month,day);
                var result = DateTime.Today.Year - birthDate.Year;
                return result;
                }

            Console.WriteLine(AgeCalculator(myYear,myMonth,myDay));
                  






            
  
            
         
                
            


      



            
        }
    }
}
