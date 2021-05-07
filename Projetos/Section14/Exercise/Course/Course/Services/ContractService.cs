using Course.Entities;
using System;

namespace Course.Services
{
    class ContractService
    {
        public static void ProcessContract(Contract contract, int monthes,IOnlinePaymentService service) 
        {
            for (int i = 0; i < monthes; i++)
            {
                DateTime _dueDate = contract.Date.AddMonths(i + 1);
                double _amount = contract.ContractValue + service.Interest(contract.ContractValue, i + 1);
                _amount += service.PaymentFee(contract.ContractValue);

                contract.installments.Add(new Installment(_dueDate,_amount));
            }
        }
    }
}
