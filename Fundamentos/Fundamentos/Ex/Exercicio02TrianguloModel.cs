namespace Fundamentos.Ex {
    public class Exercicio02TrianguloModel {

        public double MedidaA { get; set; }
        public double MedidaB { get; set; }
        public double MedidaC { get; set; }
        public double Perimetro { get; set; }
        public double Area { get; set; }


        public Exercicio02TrianguloModel(double medidaA, double medidaB, double medidaC) {
            MedidaA = medidaA;
            MedidaB = medidaB;
            MedidaC = medidaC;
            Perimetro = CalculaPerimetro(medidaA, medidaB, medidaC);
            Area = CalculaArea(medidaA, medidaB, medidaC);
        }

        private double CalculaArea(double medidaA, double medidaB, double medidaC) {
            return Math.Sqrt(Perimetro * (Perimetro - medidaA) * (Perimetro - medidaB) * (Perimetro - medidaC));
        }
        private double CalculaPerimetro(double medidaA, double medidaB, double medidaC) {
            if (medidaA > 0 & medidaB > 0 & medidaC > 0) 
                return (medidaA + medidaB + medidaC) / 2;
            else
                return -1;
        }
    }
}
