namespace Interfaces.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime Finish { get; set; }
        public Invoice Invoice  { get; set; }
        public double PricePerDay { get; set; }
        public double PricePerHour { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle, double pricePerHour, double pricePerDay)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
    }
}
