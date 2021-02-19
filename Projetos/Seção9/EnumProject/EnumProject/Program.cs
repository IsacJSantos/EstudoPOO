using System;
using EnumProject.Entities;
using EnumProject.Entities.Enums;

namespace EnumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Shipped
            };

            Console.WriteLine(order);
            Console.WriteLine("-----------------------------------");
            string txt = OrderStatus.Processing.ToString();

            Console.WriteLine("Convert enum to string: " + txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine("Covert string to enum: " + os);

            OrderStatus os2 = (OrderStatus)2;

            Console.WriteLine("Convert int to enum (with cast): " + os2);
        }
    }
}
