namespace Interfaces.Exercicio01.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public int contractRegistration { get; set; }
        public DateTime startContract { get; set; }
        public double Value { get; set; }
        public int NumberInstallments { get; set; }
        public List<Parcel> Parcels { get; set; }

        public Contract()
        {

        }

        public Contract(int registration, DateTime start, double amount, int installments)
        {
            contractRegistration = registration;
            startContract = start;
            Value = amount;
            NumberInstallments = installments;
            Parcels = new List<Parcel>();
        }
    }
}