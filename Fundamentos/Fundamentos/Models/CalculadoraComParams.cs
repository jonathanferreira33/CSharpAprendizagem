namespace Fundamentos.Models {
    public class CalculadoraComParams {


        public static double Somar(params double[] numeros) { // PARAMS vai informar ao método que a quantidade de parametros pode ser N, ou seja, quantos forem necessario
            double total = 0;
            for (int i = 0; i < numeros.Length; i++) {
                total += numeros[i];
            }
            return total;
        }
        //forma verbosa
        public static double SomarVerboso(double[] numeros) {
            double total = 0;
            for (int i = 0; i < numeros.Length; i++) {
                total += numeros[i];
            }
            return total;
        }

        //REF vc o valor passado como parametro será uma referencia a variavel original, isso tbm obriga na chamada no metodo escrever REF tbm 
        public static void Triplicar(ref int x) {
            x *= 3;
        }


        //OUT semelhante ao REf, diferença que vc mantem o valor original e guarda o resultado em outro lugar
        //direrença: no ref a variavel que for passada como parametro deve ser iniciada, no OUT ñ
        public static void Triplicar(int original, out int resultado) {
            resultado = original * 3;
        }
    }
}
