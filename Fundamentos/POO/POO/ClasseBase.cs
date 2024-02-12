namespace POO
{
    public abstract class ClasseBase
    {

        public string AtributoPai;

        public string AtributoMae;

        public ClasseBase()
        {

        }
        public ClasseBase(string atributoPai, string atributoMae)
        {
            AtributoMae = atributoPai;
            AtributoPai = atributoMae;
        }

        virtual public void MetodoVirtual() { }

        //abstract: Nao tem implementacao
        public abstract void MetodoAbstrato();
    }

}
