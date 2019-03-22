using System;
using System.Collections.Generic;

namespace homeworkClass05_whitClassMethods
{
    public class StudentClass
    {
        public List<Student> students = new List<Student>();



        public void findYoungest()
        {
            students.Sort((x, y) => x.Age - y.Age);
            Console.WriteLine($"The youngest student is {students[0].FirstName}");
        }

        public void findOldest()
        {
            students.Sort((x, y) => x.Age - y.Age);
            Console.WriteLine($"The Oldest student is {students[students.Count - 1].FirstName}");
        }

        public void LongestName()
        {
            students.Sort((x, y) => x.NameLength() - y.NameLength());
            Console.WriteLine($"The longest name between the students is {students[students.Count - 1].FirstName}");
        }

        public void SortestName()
        {
            students.Sort((x, y) => x.NameLength() - y.NameLength());
            Console.WriteLine($"The shortest name between the students is {students[0].FirstName}");
        }

        public void findAverageAge()
        {

            int sum = 0;
            foreach (var student in students)
            {
                sum += student.Age;
            }
            var average = sum / students.Count;
            Console.WriteLine($"Avegrage age of student class is {average}");
        }

    }
}
