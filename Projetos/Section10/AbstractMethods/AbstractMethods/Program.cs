using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of Shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                switch (ch)
                {
                    case 'r':
                        Console.WriteLine("Width: ");
                        double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.WriteLine("Height: ");
                        double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        list.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        Console.WriteLine("Radius: ");
                        double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        list.Add(new Circle(radius, color));
                        break;


                }

            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }


    }
}
