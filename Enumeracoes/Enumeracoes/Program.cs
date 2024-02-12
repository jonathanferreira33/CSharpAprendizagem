using Enumeracoes.Entities;
using Enumeracoes.Enums;
using System;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 10, Moment = DateTime.Now, Status = OrderStatus.Shipped
            }; 
            Console.WriteLine(order);

            //conversao
            string txt = OrderStatus.Deliveres.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Processing");
            OrderStatus os2 = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            OrderStatus os3;
            Enum.TryParse("Delivered", out os);


            Console.WriteLine(os);
        }
    }
}