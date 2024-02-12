using Interfaces.Entities;
using Interfaces.Interfaces;

namespace Interfaces.Services
{
    public class RentalService : ITaxService
    {
        private readonly ITaxService _taxService;

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public RentalService(CarRental carRental, ITaxService taxService)
        {
            PricePerHour = carRental.PricePerHour;
            PricePerDay = carRental.PricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            
            if (duration.TotalHours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalDays);

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

        public double Tax(double amouunt)
        {
            throw new NotImplementedException();
        }
    }
}
