using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkClass07
{
    class Program
    {
        static void Main(string[] args)
        {
            var nikola = new SalesPerson("Nikola", "Dalcevski", Role.Sales);
            nikola.AddSuccessRevenue(5000);
            nikola.GetSelary();
            nikola.PrintInfo();

            var venko = new Manager("Venko", "Venkovski", Role.Manager);
            venko.Selary = 1000;
            venko.AddBonus(2000);
            venko.GetSelary();
            venko.PrintInfo();
            Console.ReadKey();
        }
    }
}
