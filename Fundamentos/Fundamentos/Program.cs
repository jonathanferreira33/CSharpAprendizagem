// See https://aka.ms/new-console-template for more information
using Fundamentos;

//TIPOS
const string url = "https://github.com/jonathanferreira33/"; //constante ñ pode ser alterado depois de atribuido
string endpoint = "CSharpAprendizagem";
var url2 = $"{url}{endpoint}"; // concatenação
var numero = 10;
int numero2;
double numero5;
numero2 = 0;
char numero6 = '1';
bool verdadeiroOuFalso;
Enum diaDaSemana = Enumerador.DOMINGO; // 
diaDaSemana = (Enumerador)0; // typecast, conversao explicita

//OPERADORES
//relacionais > < != += -=
//mod % = resto da divisao
//logicos & = AND ou E | || = OR ou OU
//Bitwise << DOBRAR | >> METADE
var multiplicacao = numero * numero2;
var result = (5 + numero6) / 2;
verdadeiroOuFalso = 10 > 5; //true
verdadeiroOuFalso = 100 < 50; //false
verdadeiroOuFalso = 9 != 0.9; //false
result += 1; // igual a result = result + 1 ou result++

int resto =  30 % 4;
Console.WriteLine("Resto = " + resto); //2


verdadeiroOuFalso = (5 > 3) | (50 < 150); // TRUE caso pelo menos uma das operações é veradeira
verdadeiroOuFalso = (5 < 3) & (50 < 150); // FALSE caso pelo menos 1 seja false

Console.WriteLine(multiplicacao);

//numero = numero << 1; // 20 dobro 
//numero = numero << 2; // 40 dobro do dobro
numero = numero << 3; // 80 dobro do dobro do dobro
numero = numero >> 1; // 5 metade
Console.WriteLine(numero);

Console.WriteLine("Forma de formatação : {0} {1} {2}", url2, verdadeiroOuFalso, numero);

//LER VALORES DO TECLADO
int v1, v2;
string nome;

Console.WriteLine("Digite o seu nome :");
nome = Console.ReadLine();//para string

Console.WriteLine("Digite o primeiro valor :");
v1 = int.Parse(Console.ReadLine()); //forma 1 de conversão

Console.WriteLine("Digite o segundo valor :");
v2 = Convert.ToInt32(Console.ReadLine()); //Converte oq vem no paremetro para inteiro


//TYPECAST conversao de tipos
int v3 = 10;
float v4 = v3; //Conversao implicita ou conversao segura

double v5 = 10.15;
//float v6 = v5; //ñ possivel de conversao segura
float v6 = (float)v5; //typecast

//short v7 = v6;


//IF / ELSE 
if (v1 > v2)
{
    Console.WriteLine($"{v1} é maior que {v2}");
}
else
{
    Console.WriteLine($"{v1} é menor que {v2}");
}

int nota = 10;
int media = 5;

//if ternario
var aprovacao = (nota >= media) ? "Aprovado linha 85" : "reprovado";
Console.WriteLine(aprovacao);


//switch
Metodos.SwitchCase(nota);


//METODOS
Metodos.Aprovacao(nota, media);

int numero3 = 10;
int numero4 = 10;

Metodos.DobrarPorValor(numero3);
Console.WriteLine($"Passagem por valor: {numero3}");

Metodos.DobrarPorReferencia(ref numero4);
Console.WriteLine($"Passagem por referencia: {numero4}");

string maisAlgumaCoisa = "a";
int restoDivisao;
int quociente = Metodos.Divide(30, 4, out restoDivisao, maisAlgumaCoisa);

Console.WriteLine($"30/4 = {quociente} e o resto é {restoDivisao}");

int somarComparams = Metodos.Soma();
Console.WriteLine(somarComparams);

//GOTO
//inicio: //label
bool palmeirasTemMundial = false;

//if (!palmeirasTemMundial) goto inicio;


//ARRAY/vetor unidimencional
int[] array01 = new int[5]; //declaração de array com 5 posições (0 a 4)
int[] array02 = new int[3] {0, 55, 40};
int[] array03 = { 0, 20, 440 };

array01[4] = 1;
array01[2] = 3;
array01[3] = 2;
array01[1] = 4;
array01[0] = 5;

// 0 1 2 3 4 
//[5,4,3,2,1]

Console.WriteLine(array01[4]);// imprimir x posição

Console.WriteLine(array02[2]);// 40

Console.WriteLine(array03[2]);// 440

//MAIS DETALHES EM METODOS.METODOSPARAARRAYS


//array bidimencional
int[,] arrayBi1 = new int[5,3]; //5 linhas e 3 colunas
int[,] arrayBi2 = new int[2, 2] {{ 10, 20 }, { 15, 30 }};
/*
 * 0 20 30
 * 2 30 11 
 * 4 14 15
 * 8 99 98
 * 0 15 23
 */
arrayBi1[0,2] = 30;
arrayBi1[4,2] = 23;
arrayBi1[2,1] = 14;
arrayBi1[0,0] = 0;
arrayBi1[3,2] = 99;
arrayBi1[4,1] = 15;


Console.WriteLine("LAÇO FOR:");

//INTERAÇAO FOR
//Principalmente usado quando se sabe o numero de comandos

//   contador  ; expressao logica  ; incremento ou decremento
for (int i = 0 ; i < array01.Length; i++ )
{
    Console.WriteLine(array01[i]);
    if (array01[i] == 2) break;
}

// FOREACH
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int total = 0;
foreach (int number in numbers)
{
    total += number;
    if (number == 3)
    {
        Console.WriteLine(" Acessei o IF e retornei ao foreach");
        continue;
    }
    if (number == 7) break; // encerra apenas o loop mais interno que a contém
    if (total == 5) return; //encerra a execução da função em que aparece e devolve o controle e o resultado da função, se houver, ao chamador.

    Console.Write($"Numero = {number} |");
    Console.WriteLine($"Total = {total} ");
}

// WHILE ñ tiver certeza da quantidade de operações

int anoAtual = 2022;
while (!palmeirasTemMundial)
{
    while (anoAtual < 3000)
    {
        Console.WriteLine("Cheirinho, Ano = {0} ", anoAtual);
        anoAtual++;
    }
    palmeirasTemMundial = true;
}
Console.WriteLine($"Ano= {anoAtual}, TALVEZ, QUASE CERTEZA Q Ñ");
Console.Clear();


do
{
    Console.WriteLine("Acesso pelo menos 1 vez");
} while (!palmeirasTemMundial);








//Tipos numericos
//https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types