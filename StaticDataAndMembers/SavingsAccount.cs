using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double Balance;
        static double InterestRate;

        public static void SetInterestRate(double newRate)
        => InterestRate = newRate;
        public static double GetInterestRate()
        => InterestRate;

        public SavingsAccount(double balance)
        {
            Balance = balance;
        }
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!");
            InterestRate = 0.04;
        }
    }
}
