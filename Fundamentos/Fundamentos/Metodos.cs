using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public  class Metodos
    {
        public static string Aprovacao(int nota, int media) //IF ALINHADO
        {

            //quando ñ a + que 1 comando a partir do resultado do if ñ existe necessidade de {}
            if (nota > 10) return "Valor incoerente para nota";
            else if (nota >= media) return "Aprovado";
            else if (nota > (media - 1) & nota < media) return "Recupecao";
            else return "Reprovado";
           
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
                    return "Aprovado");
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
    }
}
