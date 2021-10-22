
using System;

namespace LogReader.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime Datelog { get; set; }
        public User(string name, DateTime timelog) 
        {
            Name = name;
            Datelog = timelog;
        }

        public override string ToString()
        {
            return $"User name: {Name}. Log date: {Datelog}";
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is User)) 
            {
                Console.WriteLine("The obj is not a User");
                return false;
            }

            User user = obj as User;
            return user.Name == Name;

        }
    }
}
