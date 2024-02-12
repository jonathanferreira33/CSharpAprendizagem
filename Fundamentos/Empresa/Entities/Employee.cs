namespace Empresa.Entities
{
    public class Employee : BaseEmployee
    {
        public Employee(string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public override double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
