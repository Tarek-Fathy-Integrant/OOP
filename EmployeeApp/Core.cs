using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal partial class Employee
    {
        //Fields
        private string _empName;
        private int _empAge;
        private int _empId;
        private string _empSSN;
        private float _currPay;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;

        //Properties
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }

        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }

        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }
    }
}
