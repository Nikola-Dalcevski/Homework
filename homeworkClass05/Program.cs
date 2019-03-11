using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass05
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Exercise 01 Student Class------");
      
            Student[] Students = new Student[5];
            Students[0] = new Student("Nikola", "Web Development", "G4");
            Students[1] = new Student("Vukasin", "Web Development", "G3");
            Students[2] = new Student("Venko", "Web Design", "G2");
            Students[3] = new Student("Dean", "Graphic Design", "G4");
            Students[4] = new Student("Vasil", "Web Development", "g5");

            Console.WriteLine("Enter student name. ex'Nikola,Vukasin,Venko'");
            var input = Console.ReadLine();
            bool isFind = false;
            for(int i = 0; i < Students.Length;i++)
            {
                if (!isFind)
                {
                    if (input == Students[i].Name)
                    {
                        Console.WriteLine(Students[i].Info());
                        isFind = true;
                    }
                }
            }
            
            if(!isFind)
            {
                Console.WriteLine("There is no student with that name");
            }
            else
            {
                isFind = false;
            }

            Console.ReadKey();


            Console.WriteLine("----exercise 02 -----");
            var userPersons = new Persons();

            while (true)
            {
                Array.Resize(ref userPersons.names, userPersons.names.Length + 1);
                Array.Resize(ref userPersons.ages, userPersons.ages.Length + 1);

                Console.WriteLine("Enter name");

               userPersons.names[userPersons.names.Length - 1] = Console.ReadLine();

                Console.WriteLine("Enter person age");
                var userAge = Console.ReadLine();
                bool isNumber = int.TryParse(userAge, out int age);
                userPersons.ages[userPersons.ages.Length - 1] = age;

                Console.WriteLine("Do you whant to enter another name? Y/n");

                string userInput = Console.ReadLine();

                if (userInput == "n" || userInput == "N")
                {
                    break;
                }

            }

              Console.WriteLine( userPersons.Oldest());
            

          

            
            Console.ReadKey();

        }
    }
}
