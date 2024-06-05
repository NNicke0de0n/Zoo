using System;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AnimalType { get; set; }
        public string Sex { get; set; }

        public string EatType { get; set; }

        public Animal(string name, string descroption, string animalType, string eatType, string sex) 
        {
            Name = name;
            Description = descroption;
            AnimalType = animalType;
            Sex = sex;
            EatType = eatType;
        }
    }
}