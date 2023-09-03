using System;
using Module17.Accounts;

namespace Module17.Accounts
{
    class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public SalaryAccount(double balance)
        {
            Balance = balance;
        }

        public void Calculate()
        {
            Interest = Balance * 0.5;

            Console.WriteLine($"процентная ставка: {Interest}");
        }
    }
}