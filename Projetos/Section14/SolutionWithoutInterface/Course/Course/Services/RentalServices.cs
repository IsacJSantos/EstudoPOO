using System;
using Course.Entities;

namespace Course.Services
{
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan durarion = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            if (durarion.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(durarion.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(durarion.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
