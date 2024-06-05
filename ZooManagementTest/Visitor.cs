using System;

namespace Zoo
{
    internal class Visitor
    {
        public int Age {  get; set; }
        public Gender Sex { get; set; }
        public DateTime DateOfVisit { get; set; }

        public Visitor(int age, Gender sex, DateTime dateOfVisit) 
        {
            Age = age;
            Sex = sex;
            DateOfVisit = dateOfVisit;
        }
    }
}