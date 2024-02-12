// See https://aka.ms/new-console-template for more information
using POO;
using POO.Heranca;

Classe classe01 = new Classe();
classe01.AtributoMae = "mae";
classe01.AtributoPai = "pai";
classe01.AtributoFilho = "filho";
classe01.AtributoFilha = "filha";

Console.WriteLine(classe01.AtributoMae);

/// <summary>
/// Herança
/// </summary>
Account acc = new Account(1001, "Jhoou", 0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Flores", 0.0, 500.0);

//UPCASTING
Account acc01 = bacc;
Account acc02 = new BusinessAccount(1003, "Maria", 0.0, 200.0);
Account acc03 = new SavingsAccount(1004, "Iza", 0.0, 0.01);


//DownCasting
BusinessAccount bacc01 = (BusinessAccount)acc02;
bacc01.Loan(100.0);

//BusinessAccount bacc03 = (BusinessAccount)acc03; // InvalidCastException: erro em tempo de execucao

if(acc03 is BusinessAccount)
{
    //BusinessAccount bacc03 = (BusinessAccount)acc03;
    BusinessAccount bacc03 = acc03 as BusinessAccount;
    bacc03.Loan(200.0);
    Console.WriteLine("Loan!");
}

if(acc03 is SavingsAccount)
{
    //SavingsAccount sacc01 = (SavingsAccount)acc03;
    SavingsAccount sacc01 = acc03 as SavingsAccount;
    sacc01.UpdateBalance();
    Console.WriteLine("Update!");

}


Account acc05 = new Account(1001, "Alex", 500.0);
Account acc06 = new SavingsAccount(1002, "Alex", 500.0, 0.01);

acc05.WithDraw(10.0);
acc06.WithDraw(10.0);

Console.WriteLine(acc05.Balance);
Console.WriteLine(acc06.Balance);