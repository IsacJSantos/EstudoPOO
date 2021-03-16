using System;
using ExenptionExercise.Entities.Exenptions;

namespace ExenptionExercise.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
        }
        public Account(int number, string holder, double balance, double withDrawLimit) : this(number, holder, balance)
        {
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount) 
        {
            if(amount > 0)
            Balance += amount;
        }
        public void WithDraw(double amount) 
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainExenption("Not enough balance!");
            }
            else if (Balance < amount) 
            {
                throw new DomainExenption("The amout exceeds withdraw limit!");
            }

            Balance -= amount;
        }

    }
}
