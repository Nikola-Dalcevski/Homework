namespace homeworkClass07
{
    internal class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, Role role) : base(firstName, lastName, role)
        {
            Role = Role.Manager;
        }

        public void AddBonus(double value)
        {
            Bonus = value;
        }

        public override double GetSelary()
        {
            return base.Selary += Bonus;
        }

    }
}