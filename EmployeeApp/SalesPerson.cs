using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class SalesPerson : Employee
    {
        //Properties
        public int SalesNumber { get; set; }
        //Constructors
        public SalesPerson() { }
        public SalesPerson(string fullnName, int age, int empId, float currPay, string ssn, int salesNum)
        : base(fullnName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commission)
        {
            SalesNumber = salesNum;
        }
        //Methods
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Number of Sales: {SalesNumber}");
        }
    }
}
