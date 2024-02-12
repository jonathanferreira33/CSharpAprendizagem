


using Generics_Ste_Dicionary.Entities;

HashSet<string> set = new HashSet<string>();
set.Add("gato");
set.Add("cachorro");
set.Add("ovelha");
set.Add("jacaré");

Console.WriteLine(set.Contains("girafa"));

foreach (string item in set)
{
    Console.WriteLine(item);
}


SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 7, 6, 8, 10 };
SortedSet<int> b = new SortedSet<int>() { 5, 8, 10, 45, 17, 6, 1, 10 };

//unir 2 conjuntos
SortedSet<int> ab = new SortedSet<int>(a);
ab.UnionWith(b); // todos que já não existam ainda
Console.WriteLine("ab:");
PrintCollention(ab);

//interseccao
SortedSet<int> i = new SortedSet<int>(a);
i.IntersectWith(b); // elementos que existem em amos os conjuntos
Console.WriteLine("i:");
PrintCollention(i);


// Diderença
SortedSet<int> d = new SortedSet<int>(a);
i.ExceptWith(b); // diferença entre a, excluindo o que existia em b 
Console.WriteLine("d:");
PrintCollention(d);

HashSet<Product> products = new HashSet<Product>(); //não tem  gethashcode e equal implementardos
products.Add(new Product("TV", 3000.5));
products.Add(new Product("Alexia", 300.5));

var product = new Product("TV", 3000.5);
Console.WriteLine(products.Contains(product)); //false, pois assim utiliza-se referencia



HashSet<Point> points = new HashSet<Point>();
points.Add(new Point(10, 25));
points.Add(new Point(5, 40));

Point point = new Point(10, 25);
Console.WriteLine(points.Contains(point)); // true, Point tipo struct nao classe, comparacao por conteudo


//Exercicio 01
HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while(!sr.EndOfStream){
            string[] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            logRecords.Add(new LogRecord { User = name, Instant = instant });
            //Console.WriteLine(line);
        }
        Console.WriteLine($"Total users: {logRecords.Count}");
    }
} catch (IOException e)
{
    Console.WriteLine(e.Message);
}


Dictionary<string, string> cookies = new Dictionary<string, string>(); //chave e valor

cookies["user"] = "maria";
cookies["email"] = "maria@email.com";
cookies["fone"] = "11987654321";
cookies["fone"] = "11123456789"; // não aceita repeticao, logo o primeiro valor é sobreposto
                                 // 
Console.WriteLine(cookies["fone"]);

if (cookies.ContainsKey("user"))
    Console.WriteLine(cookies["user"]);
else
    Console.WriteLine("There is no 'user' key");

cookies.Remove("user");

Console.WriteLine($"Size: {cookies.Count}");

foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}



static void PrintCollention<T>(IEnumerable<T> colletion)
{
    foreach (T item in colletion)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine("");
}