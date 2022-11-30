using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal abstract partial class Employee
    {
        //Fields
        protected string EmpName;
        protected int EmpAge;
        protected int EmpId;
        protected string EmpSSN;
        protected float CurrPay;
        protected EmployeePayTypeEnum EmpPayType;
        protected DateTime EmpHireDate;
        protected BenefitPackage EmpBenefits = new BenefitPackage();
        //Properties
        public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }

        public int Age
        {
            get { return EmpAge; }
            set { EmpAge = value; }
        }

        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public string SocialSecurityNumber
        {
            get => EmpSSN;
            private set => EmpSSN = value;
        }

        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }

        public DateTime HireDate
        {
            get => EmpHireDate;
            set => EmpHireDate = value;
        }
    }
}
