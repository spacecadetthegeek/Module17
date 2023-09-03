using System;
using System.Security.Principal;
using Module17.Accounts;

namespace Module17
{
    class Calculator
    {
        public void PerformCalculate(IAccount accountType)
        {
            accountType.Calculate();
        }
    }
}
