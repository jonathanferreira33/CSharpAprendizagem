using Fundamentos.Models;
using System.Globalization;

namespace Fundamentos {
    internal class Vetores {

        public static double[] PopularVetor(double[] vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            return vetor;
        }

        public static object[] PopularVetor(object[] vetor) {
            for (int i = 0; i < vetor.Length; i++) {
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto { Nome = nome, Valor = valor };
            }
            return vetor;
        }
    }
}
