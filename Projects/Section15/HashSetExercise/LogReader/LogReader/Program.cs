using System;
using System.Collections.Generic;
using System.IO;
using LogReader.Entities;

namespace LogReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path: ");
            string path = Console.ReadLine();

            HashSet<User> userlist = new HashSet<User>();
            
            try
            {
                using (StreamReader _sr = File.OpenText(path))
                {
                    while (!_sr.EndOfStream)
                    {
                        string[] s = _sr.ReadLine().Split(' ');
                        DateTime dateLog = DateTime.Parse(s[1]);
                        string name = s[0];
                        User user = new User(name, dateLog);
                        userlist.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            Console.WriteLine($"Total users: {userlist.Count}");
        }
    }
}
