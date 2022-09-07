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
//logicos & = AND ou E | || = OR ou OU
//Bitwise << DOBRAR | >> METADE
var multiplicacao = numero * numero2;
var result = (5 + numero6) / 2;
verdadeiroOuFalso = 10 > 5; //true
verdadeiroOuFalso = 100 < 50; //false
verdadeiroOuFalso = 9 != 0.9; //false
result += 1; // igual a result = result + 1 ou result++

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
var aprovacao = (nota >= media) ? "Aprovado" : "reprovado";
Console.WriteLine(aprovacao);


//switch
Metodos.SwitchCase(nota);


//METODOS
Metodos.Aprovacao(nota, media);


//GOTO
inicio: //label
bool palmeirasTemMundial = false;

if (!palmeirasTemMundial) goto inicio;

//Tipos numericos
//https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types