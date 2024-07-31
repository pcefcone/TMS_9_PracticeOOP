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

        public void Credit(int years)
        {
            int count = 1;
            int countYears = years;
            while (count < countYears)
            {
                Balance *= InterestRate;
                countYears--;
            }
            Console.WriteLine($"After {years} years, your balance will be {Math.Round(Balance, 2)}");
        }
    }

}
