﻿using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }

        public List<Installment> installments = null;

        public Contract(int number, DateTime date, double contractValue)
        {
            Number = number;
            Date = date;
            ContractValue = contractValue;
        }
    }
}
