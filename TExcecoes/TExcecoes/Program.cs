// See https://aka.ms/new-console-template for more information
using TExcecoes.Entities;
using TExcecoes.Entities.Exceptions;

Console.WriteLine("Hello, World!");

try
{
    int n1 = 10;
    int n2 = 0;
    int result = n1 / n2;
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Source);
    Console.WriteLine(ex.GetType().Name);

}

try
{
    var dateCheckIn = new DateTime(year: 2023, month: 5, day: 08);
    var dateCheckOut = new DateTime(year: 2023, month: 6, day: 08);

    Reservation reservation = new Reservation(183, dateCheckIn, dateCheckOut);
    Console.WriteLine(reservation.ToString());

    var newDateCheckIn = new DateTime(year: 2023, month: 10, day: 9);
    var newDateCheckOut = new DateTime(year: 2023, month: 5, day: 10);

    reservation.UpdateDates(newDateCheckIn, newDateCheckOut);
    Console.WriteLine(reservation.ToString());

}
catch (DomainException ex)
{
    Console.WriteLine($"Erro: {ex.message}");

}
