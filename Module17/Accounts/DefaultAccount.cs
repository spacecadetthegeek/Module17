using System;
using System.Security.Principal;

namespace Module17.Accounts
{
    class DefaultAccount : IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public DefaultAccount(double balance)
        {
            Balance = balance;
        }

        public void Calculate()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"процентная ставка: {Interest}");
        }
    }
}