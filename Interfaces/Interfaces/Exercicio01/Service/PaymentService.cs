using Interfaces.Exercicio01.Entities;
using Interfaces.Exercicio01.Interface;

namespace Interfaces.Exercicio01.Service
{
    public class PaymentService : IPaypalService
    {
        public void CalculateInstallmentValue(ref Contract contract)
        {
            var baseValue = contract.Value / contract.NumberInstallments;
            var rate = 1.02;

            for (int i = 1; i <= contract.NumberInstallments; i++)
            {
                var parcel = new Parcel();
                parcel.Value = ((i * baseValue/100) + baseValue) * rate;
                parcel.dueDate = contract.startContract.AddMonths(i);
                contract.Parcels.Add(parcel);
            }
        }
    }
}
