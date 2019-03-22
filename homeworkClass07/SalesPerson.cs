namespace homeworkClass07
{
    internal class SalesPerson : Employee
    {
        private double SuccessSalesRevenue { get; set; }

        public SalesPerson(string firstName, string lastName, Role role)
            : base(firstName, lastName, role)
        {
            Role = Role.Sales;
            base.Selary = 500;
        }
        public void AddSuccessRevenue(double value)
        {
            SuccessSalesRevenue = value;
        }
        public override double GetSelary()
        {
            if (SuccessSalesRevenue <= 2000)
            {
                return base.Selary += 500;

            }
            else if (SuccessSalesRevenue > 2000 && SuccessSalesRevenue <= 5000)
            {
                return base.Selary += 1000;
            }
            else
            {
                return base.Selary += 1500;
            }

        }

    }
}