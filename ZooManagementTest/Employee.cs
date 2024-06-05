using System;

namespace Zoo
{
    public class Employee
    {
        //cooment for the test
        //two comment

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
    }
}