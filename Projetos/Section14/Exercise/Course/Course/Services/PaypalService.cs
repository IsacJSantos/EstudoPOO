using System;

namespace Course.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int monthes)
        {
            return amount * (0.01 * monthes);
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
