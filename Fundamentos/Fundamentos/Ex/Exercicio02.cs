namespace Fundamentos.Ex {
    public static class Exercicio02 {

        public static string Exercicio2(double Aa, double Ab, double Ac, double Ba, double Bb, double Bc) {

            // Comprar calcular a area de 2 tringulos e informar qual possui a maior area, pode usar entrada de dados
            //Usar fórmula de Heron
            //triangulo 1

            double p = (Aa + Ab + Ac) / 2;
            double areaTA = Math.Sqrt(p * (p - Aa) * (p - Ab) * (p - Ac));//raiz quadrada

            p = (Ba + Bb + Bc) / 2;
            double areaTB = Math.Sqrt(p * (p - Ba) * (p - Bb) * (p - Bc));
            string maiorArea = (areaTA > areaTB) ? "Triangulo A" : "triangulo B";

            return $"Area triangulo A = {Math.Round(areaTA, 2)} | Area triangulo B = {Math.Round(areaTB, 2)} | Maior area: {maiorArea}  ";
        }

        public static string Exercicio2(Exercicio02TrianguloModel a, Exercicio02TrianguloModel b) { // metodo deveria se chamar: MaiorTrinagulo

            string maiorArea = (a.Area > b.Area) ? "Triangulo A" : "Triangulo B";

            return $"Area triangulo A = {Math.Round(a.Area, 2)} | Area triangulo B = {Math.Round(b.Area, 2)} | Maior area: {maiorArea}  ";

        }
    }
}
