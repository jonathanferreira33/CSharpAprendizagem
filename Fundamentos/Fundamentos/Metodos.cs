using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Metodos
    {

        //METODOS É UM BLOCO DE INSTRUÇÃO


        public static string Aprovacao(int nota, int media) //IF ALINHADO
        {

            //quando ñ a + que 1 comando a partir do resultado do if ñ existe necessidade de {}
            if (nota > 10) return "Valor incoerente para nota";
            else if (nota >= media) return "Aprovado";
            else if (nota > (media - 1) & nota < media) return "Recupecao";
            else return "Reprovado";

        }

        //Passagem por valor
        public static void DobrarPorValor(int numero)
        {
            numero *= 2;
        }

        //Passagem por referencia
        public static void DobrarPorReferencia(ref int numero)
        {
            numero *= 2;
        }

        //OUT
        public static int Divide(int dividendo, int divisor, out int resto, string outraCoisa)
        {
            outraCoisa = "Qualquer outra coisa";
            int quociente;
            quociente = dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }

        //PARAMS
        public static int Soma(params int[]array)
        {
            int resutado=0;
            if (array.Length == 0) return 0;
            else if(array.Length == 1) return array[0];
            else
            {
                foreach (int i in array)
                {
                    resutado += i;
                }
                return resutado;
            }

        }

        public static string SwitchCase(int nota)
        {
            switch (nota)
            {
                case 10:
                    return "Aprovado com méritos";
                case 9:
                    return "Aprovado, parabens";
                //break;
                case 8:
                    return "Aprovado";
                case 7:
                    return "Aprovado, mas pode melhorar";
                case 6:
                    return "passou";
                case 5:
                    return "NA TRAVE EM?!";
                case 4:
                    return "Ñ ARREDONDAMOS!";
                case 3:
                    return "CHAMA ISSO DE NOTA ?";
                case 2:
                    return "PQ?";
                case 1:
                    return "SÓ ISSO ?";
                case 0:
                    return "kkkkkkkk";
                default: // cai sempre que nenhum caso seja atendido
                    return "Nota desconhecida";
            }
        }

        public int MetodosParaArray()
        {
            int[] numbers01 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers02 = new int[10];
            int[] numbers03 = new int[10];
            int[] numbers04 = new int[10];
            int[] numbers05 = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers02.Length; i++)
                numbers02[i] = random.Next(100); //99 significa o valor maximo

            //SEMPRE OBSERVAR O TIPO DO RETORNO

            //BinarySearch, busca a posicao de um elemnto em um array
            int encontrar = 25;
            int posicao = Array.BinarySearch<int>(numbers02, encontrar);
            //caso ñ encontrado o retorno será um valor negativo


            //Copy(arrayDeOrigem, arrayDeDestino, QNTdePosicoes) copia um array para outro
            Array.Copy(numbers03,numbers02, numbers02.Length);


            //CopyTo(ArrayDeDstino, aPartirDeQualPosicao) - a partir do vetor de origem 
            numbers01.CopyTo(numbers04,0);

            //GetValue - retorna valor a partir de um indice
            numbers03.GetValue(3);

            //IndexOf(array, valor) - retorna a posicao da primeira vez q encontrar o valor pesquisado
            int indice = Array.IndexOf(numbers02, 50);

            //LastIndexOf - retorna a posicao da ultima vez q encontrar o valor pesquisado
            int ultimoIndice = Array.LastIndexOf(numbers02, 50);

            //Reverse - inverte as posições de um array
            // sem reverse  [0, 99, 52, 90]
            // com reverse [90, 52, 99, 0]
            Array.Reverse(numbers04);

            //SetValue(valor, posicao)
            numbers04.SetValue(50, 0);


            //Sort - Colocar os valores em ordem crescente
            Array.Sort(numbers01);
            //caso queira colocar em modo descresente basta fazer um reverse apos o sort
            Array.Reverse(numbers01);

            return 0;
        }

        //ATIVIDADE
        //CONTRUIR METODO QUE RECEBE UM ARRAY
        //MULTIPLICA CADA VALOR POR 2
        //E RETORNA EM ORDEM DECRESCENTE   
    }
}
