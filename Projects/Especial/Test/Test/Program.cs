using System;
using Test.Enitites;
using Test.Entities.LinkedList;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Order> orderList = new LinkedList<Order>();

            Console.Write("How moch Order do you want? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the Order #{i} data: ");

                Console.Write("Client name: ");
                string cName = Console.ReadLine();

                Order order = new Order(cName);

                Console.Write("How moch Products for this order? ");
                int x = int.Parse(Console.ReadLine());

                for (int j = 1; j <= x; j++)
                {
                    Console.WriteLine($"Enter the product #{i} data: ");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price");
                    double price = double.Parse(Console.ReadLine());

                    Product product = new Product(name, price);

                    order.AddProduct(product);
                }

                orderList.Add(order);
            }

           
        }
    }
}
