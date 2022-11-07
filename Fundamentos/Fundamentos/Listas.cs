namespace Fundamentos {
    internal class Listas {

        // LISTAS = estrutura de dados homogênea, ordaenada, inicia vazia e cada elemento ocupa um nó(nodo) da lista
        // vantagens: tamanho variável e facilidade de realizar inserções e deleções
        // desvan : Acesso serquencial aos elementos *
        List<string> listaDeString = new List<string>(); // Intanciação q criou uma lista vazia
        public static List<string> listaDeNomes = new List<string> { "Jonathan", "Ingrid" }; // Intanciação q criou uma lista com membros

        // Inserir elemento : Add ou Insert
        //      add = adiciona no final
        //      insert = precisa dizer em qual posição
        // Tamnho da lista: Count
        // Encontrar primeiro e ultimo elemento que satisfaça um predicado: list.Find e list.FindLast (predicado == função)
        // Encontrar primeiro ou ultimo elemento: list.FindIndex, list.FindLastIndex
        // Filtrar a lista com base em um predicado: list.FindAll
        // Remover elementos: remove, RemoveAll, RemoveAt, RemoveRange


    }
}
