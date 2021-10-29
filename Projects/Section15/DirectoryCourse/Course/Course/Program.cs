using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Isac";
            cookies["email"] = "isac4322@gmail.com";
            cookies["phone"] = "21976707714";

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("phone");

            if (cookies.ContainsKey("phone"))
                Console.WriteLine(cookies["phone"]);

            Console.WriteLine($"Size {cookies.Count}");

            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
