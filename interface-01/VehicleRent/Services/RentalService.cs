using System;
using VehicleRent.Entities;

namespace VehicleRent.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            if (duration.TotalHours > 12)
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            else
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
