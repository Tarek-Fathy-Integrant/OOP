using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Manager : Employee
    {
        //Propeties
        public int StockOptions { get; set; }
        //Constructors
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int numOfOpts)
            : base (fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numOfOpts;
        }
        //Methods
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Stock Options: {StockOptions}");
        }
    }
}
