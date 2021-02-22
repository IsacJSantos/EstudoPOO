using System;
using System.Globalization;
using Client_OrderProject.Entities;
using Client_OrderProject.Entities.Enums;

namespace Client_OrderProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, email,birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(prodName,quantity, price);

                order.AddItem(item);
            }

            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
