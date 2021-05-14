using System;

namespace Course.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int monthes)
        {
            Console.WriteLine(amount * (0.01 * monthes));
            return amount * (0.01 * monthes);
        }

        public double PaymentFee(double amount)
        {
            Console.WriteLine(amount * 0.02);
            return amount * 0.02;
        }
    }
}
