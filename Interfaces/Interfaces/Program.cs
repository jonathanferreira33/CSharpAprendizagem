﻿//Uma locadora brasileira de carros cobra um valor por hora para locações de até
//12 horas. Porém, se a duração da locação ultrapassar 12 horas, a locação será
//cobrada com base em um valor diário. Além do valor da locação, é acrescido no
//preço o valor do imposto conforme regras do país que, no caso do Brasil, é 20%
//para valores até 100.00, ou 15% para valores acima de 100.00. Fazer um
//programa que lê os dados da locação (modelo do carro, instante inicial e final da
//locação), bem como o valor por hora e o valor diário de locação. O programa
//deve então gerar a nota de pagamento (contendo valor da locação, valor do
//imposto e valor total do pagamento) e informar os dados na tela. Veja os
//exemplos.

//Enter rental data
//Car model: Civic
//Pickup(dd/MM/yyyy hh:mm): 25 / 06 / 2018 10:30
//Return(dd / MM / yyyy hh: mm): 25 / 06 / 2018 14:40
//Enter price per hour: 10.00
//Enter price per day: 130.00
//INVOICE:
//Basic payment: 50.00
//Tax: 10.00
//Total payment: 60.00


using Interfaces.Entities;
using Interfaces.Exercicio01.Entities;
using Interfaces.Exercicio01.Service;
using Interfaces.Services;

string model = "Civic";
DateTime start = DateTime.Now;
start.AddDays(-2);
DateTime finish = DateTime.Now;

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rs = new RentalService(20.0, 200.0, new BrazilTaxService()); 

Contract contract = new Contract(2020, DateTime.Now, 600.0, 3);

var service = new PaymentService();
service.CalculateInstallmentValue( ref contract);

contract.Parcels.ToString();