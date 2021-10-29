using System;
using System.Collections.Generic;
using System.Text;

namespace SealedClassesAndMethods.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestrate)
            : base(number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // This method cannot be overrided again
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
        }

    }
}
