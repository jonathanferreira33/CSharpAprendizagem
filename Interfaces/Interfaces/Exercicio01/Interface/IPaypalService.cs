using Interfaces.Exercicio01.Entities;

namespace Interfaces.Exercicio01.Interface
{
    public interface IPaypalService
    {
        public void CalculateInstallmentValue(ref Contract contract);
    }
}
