// See https://aka.ms/new-console-template for more information
using Exercicio04_Banco;
using Exercicio04_Banco.Helper;


ContaModel contaDaIngrid = new ContaModel("Ingrid M");
Console.WriteLine($" Olá {contaDaIngrid.NomeTitular}, sua nova conta: {contaDaIngrid.NumeroConta}");

ContaModel contaDoJonathan = new ContaModel("Jonathan F");
Console.WriteLine($" Olá {contaDoJonathan.NomeTitular}, sua nova conta: {contaDoJonathan.NumeroConta}");

DataBase.listaDeContas.Add(contaDaIngrid.NumeroConta, contaDaIngrid);
DataBase.listaDeContas.Add(contaDoJonathan.NumeroConta, contaDoJonathan);


Console.WriteLine("Bem vindo ao banco NoiteEstreladaBank \nDigite o numero da conta");
var NumeroContaCorrente = int.Parse(Console.ReadLine());

var conta = DataBase.listaDeContas[NumeroContaCorrente];
Console.WriteLine("Escolha a opção desejada:");
Console.WriteLine("1) Saldo \n2) Mudar Nome \n3) Extrato \n4) Fazer Deposito \n0) Para sair");
var resposta = int.Parse(Console.ReadLine());

while (resposta != 0) {

    if (resposta == 0) {
        resposta = 0;
    }

    if(resposta == 1) {
        Console.WriteLine($"Saldo atual: {conta.ConsultaSaldo()}");
    }

    if (resposta == 2) {
        Console.WriteLine("Digite o novo nome:");
        var novoNome= Console.ReadLine();
        conta.MudarNome(novoNome);
    }

    if (resposta == 3) {
        Console.WriteLine(conta.Extrato(conta.NumeroConta));
    }

    if (resposta == 4) {
        Console.WriteLine("Digite o valor do deposito:");
        var valor = double.Parse(Console.ReadLine());
        conta.Deposito(valor);
    }
    Console.WriteLine("Escolha nova opção desejada \n1) Saldo \n2) Mudar Nome \n3) Extrato \n4) Fazer Deposito \n0) Para sair");
    resposta = int.Parse(Console.ReadLine());
}


Console.WriteLine("bye bye");


