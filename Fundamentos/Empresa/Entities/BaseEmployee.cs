namespace Empresa.Entities
{
    public abstract class BaseEmployee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public BaseEmployee(string name, int hours, double valuePerHour) { }

        public abstract double Payment();

    }
}
