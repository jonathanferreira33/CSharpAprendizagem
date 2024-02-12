namespace Empresa.Entities
{
    public class OutsourcedEmployee : BaseEmployee
    {
        public double AdditionalChange { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalChange) :
            base (name, hours, valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHours;
            AdditionalChange = additionalChange;
        }
        public override double Payment()
        {
            return (ValuePerHour * Hours) + (1.1 * AdditionalChange);
        }
    }
}
