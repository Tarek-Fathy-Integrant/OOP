using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson(string fullName, int age, int empId, float currPay, string ssn, int salesNum)
            : base(fullName, age, empId, currPay, ssn, salesNum)
        {
        
        }
    }
}
