using Course.Entities;
using System;

namespace Course.Services
{
    class ContractService
    {
        public static void ProcessContract(Contract contract, int monthes,IOnlinePaymentService service) 
        {
            double monthValue = contract.ContractValue / monthes;
            for (int i = 0; i < monthes; i++)
            {
                DateTime _dueDate = contract.Date.AddMonths(i + 1);     
                double _amount = monthValue + service.Interest(monthValue, i + 1);
                _amount += service.PaymentFee(monthValue);

                contract.installments.Add(new Installment(_dueDate,_amount));
            }
        }
    }
}
