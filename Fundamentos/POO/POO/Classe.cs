namespace POO {

    //especificador de acesso(onde a classe pode ser instanciada): public, internal, private, protected
    //Classe abstratc, classe base, como base para criação de outras classe
    //sealed: Não pode ser herdada
    //static: Não permite a intanciação de objetos e seus membros devem ser herdados

    public class Classe : ClasseBase {
        public string AtributoFilha { get; set; }
        public string AtributoFilho { get; set; }

        //Construtor
        public Classe() : base() {

        }

        //Sobrecarga
        public Classe(string atributoFilha) {
            AtributoFilha = atributoFilha;
        }

        public Classe(string atributoFilho, string atributoFilha) {
            AtributoFilho = atributoFilho;
            AtributoFilha = atributoFilha;
        }



        //Desconstrutor, serve para destruir (sim, deveria se chamar destruidor)
        ~Classe() { }


        //Metodos
        //especificador de acesso
        //sealed: nao pode ser redefinido
        //virtual: pode ser definido na classe herdada
        //static: pode ser chamado sem instancia
        //override: Sobrescreve o metodo do classe base
        //abstract: Obriga a implementação do método quando a classe é herdada e ñ é possivel intanciar
        override public void MetodoVirtual() {
            Console.WriteLine("faz uma coisa");
        }

        public override void MetodoAbstrato() {
            Console.WriteLine("metodo obrigatório por ser abstrato na base");
        }
    }
}
