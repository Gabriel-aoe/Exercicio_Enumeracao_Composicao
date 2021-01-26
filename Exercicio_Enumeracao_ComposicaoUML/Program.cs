using System;
using System.Globalization;
using Exercicio_Enumeracao_ComposicaoUML.Entities;
using Exercicio_Enumeracao_ComposicaoUML.Entities.Enums;

namespace Exercicio_Enumeracao_ComposicaoUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Day(DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Console.WriteLine("Moment: " + moment);

            Client client = new Client(name, email, birthDay);
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(moment, status, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i}");
            }

        }
    }
}
