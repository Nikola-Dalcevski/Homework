namespace homeworkClass05
{
    internal class Student
    {
        public string Name;
        public string Academy;
        public string Group;
        public string Info()
        {
            return $"{Name} is in group {Group} at academy of {Academy}";
        }

        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
    }
}