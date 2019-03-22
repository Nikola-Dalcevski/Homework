using System;

namespace homeworkClass07
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Selary { get; set; }

        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} has selary of {Selary}$ ");
        }
        public virtual double GetSelary()
        {
            return Selary;
        }

    }
}
