using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass05_whitClassMethods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var newClass = new StudentClass();
            newClass.students.Add(new Student("Nikola", "Dalcevski", 31));
            newClass.students.Add(new Student("Vukasin", "Obradovic", 34));
            newClass.students.Add(new Student("Venko", "Venkovski", 35));
            newClass.students.Add(new Student("Perso1", "Person1Lname", 27));
            newClass.students.Add(new Student("Person2", "Person2Lname", 30));

            bool chekForNewadd = true;
            while (chekForNewadd)
            {
                Console.WriteLine($"The group of students have {newClass.students.Count} members");
                Console.WriteLine($"Do You whant to enter new student? Y/n");
                string userInput = Console.ReadLine();
                if (userInput == "N" || userInput == "n")
                {
                    chekForNewadd = false;
                    break;
                }
                Console.WriteLine("Enter Student first name");
                var userFirstName = Console.ReadLine();
                Console.WriteLine("Enter Student last name");
                var userLastName = Console.ReadLine();
            start:
                Console.WriteLine("Enter Student age");
                var userAge = Console.ReadLine();
                var isNumber = int.TryParse(userAge, out int age);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    goto start;
                }

                newClass.students.Add(new Student(userFirstName, userLastName, age));

            }

            Console.Write($"Basic info about the group");

            newClass.findYoungest();
            newClass.findOldest();
            newClass.LongestName();
            newClass.SortestName();
            newClass.findAverageAge();


            Console.WriteLine("-------------");
            Console.WriteLine($"Do you whant to search information about individual student: Y/n");
            var userInput2 = Console.ReadLine();
            if (userInput2 == "N" || userInput2 == "n")
            {
                Console.WriteLine("Hava a nice day");
            }
            else
            {

                foreach (var student in newClass.students)
                {
                    Console.WriteLine(student.FirstName);
                }

                Console.WriteLine("Chose student from the group by name:");
                var studentName = Console.ReadLine();
                foreach (var student in newClass.students)
                {
                    if (student.FirstName == studentName)
                    {
                        student.studentInfo();
                    }
                }

                Console.ReadKey();


            }
        }
    }
}
