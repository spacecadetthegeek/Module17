using System;
using Module17.Accounts;

namespace Module17
{
    class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();

            calculator.PerformCalculate(new DefaultAccount(500));

            calculator.PerformCalculate(new DefaultAccount(60000));

            calculator.PerformCalculate(new SalaryAccount(50000));
        }
    }
}