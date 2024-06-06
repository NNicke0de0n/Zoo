using System;

namespace Zoo
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, string position, decimal salary)
        {
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old, {Position}, {Salary}";
        }
    }
}