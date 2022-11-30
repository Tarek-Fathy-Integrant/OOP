using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal abstract partial class Employee
    {
        //Constructors
        public Employee() { }

        public Employee(string name, int id, float pay, string empSsn)
        : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        { }

        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }

        //Methods
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
            //Pay = this switch
            //{
            //    { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 }
            //    => Pay += .10F * amount,
            //    { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 }
            //    => Pay += 40F * amount / 2080F,
            //    { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020 }
            //    => Pay += amount,
            //    _ => Pay += 0
            //};
        }
        public double GetBenefitsCost() => EmpBenefits.ComputePayDeduction();

        public BenefitPackage Benefits
        {
            get => EmpBenefits;
            set => EmpBenefits = value;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"SSN: {SocialSecurityNumber}");
        }
        //Nested Types
        internal class BenefitPackage
        {
            enum BenefitPackageLevel
            {
                //
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
