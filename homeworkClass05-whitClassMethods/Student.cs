using System;

namespace homeworkClass05_whitClassMethods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }



        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        public void studentInfo()
        {
            Console.WriteLine($"Student {FirstName} {LastName} is {Age} years old");
        }

        public int NameLength()
        {
            return FirstName.Length;
        }
    }
}
