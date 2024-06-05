using System;

namespace Zoo
{
    internal class Visitor
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public DateTime VisitDate { get; set; }

        public Visitor(string name ,int age, Gender sex, string country, DateTime dateOfVisit) 
        {
            Name = name;
            Age = age;
            Gender = sex;
            Country = country;
            VisitDate = dateOfVisit;
        }
    }
}