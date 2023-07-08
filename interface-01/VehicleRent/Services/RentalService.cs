﻿using System;
using VehicleRent.Entities;

namespace VehicleRent.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
