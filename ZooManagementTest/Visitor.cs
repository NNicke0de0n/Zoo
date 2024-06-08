using System;

namespace Zoo
{
    public class Visitor
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Gender Gender { get; set; }
        public Countries Country { get; set; }
        public DateTime VisitDate { get; set; }

        public Visitor(string name ,int age, Gender sex, Countries country, DateTime dateOfVisit) 
        {
            Name = name;
            Age = age;
            Gender = sex;
            Country = country;
            VisitDate = dateOfVisit;
        }

        public override string ToString()
        {
            return $"{Name} {Age} years old, {Gender}, {Country}, visited on {VisitDate}";
        }
    }
}