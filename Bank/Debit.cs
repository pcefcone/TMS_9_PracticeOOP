using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_9_PracticeOOP.Bank
{
    internal class Debit
    {
        double Balance = 0;
        double InterestRate = 0;
        public Debit(double initialBalance, double initialInterestRate)
        {
            Balance = initialBalance;
            InterestRate = initialInterestRate;

        }
        public void PrintBalance()
        {
            Console.WriteLine($"Your balance is {Balance}");
        }
        public void WaitOneYear()
        {
            Balance = Balance * InterestRate;
            Console.WriteLine($"Your balance is {Balance}");
        }
    }

}
