namespace Course.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            this.salary = salary;
        }
    }
}
