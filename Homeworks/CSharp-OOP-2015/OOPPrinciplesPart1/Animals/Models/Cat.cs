﻿namespace Animals.Models
{
    class Cat : Animal
    {
        public Cat(string name, int age, Sex sex) 
            : base(name, age, sex)
        {
            this.AnimalKind = AnimalKind.Cat;
        }

        public override string ProduceSound()
        {
            return "Meow, meow!";
        }

        public override string ToString()
        {
            return ProduceSound() + " " +  base.ToString() + " " + this.AnimalKind + ".";
        }
    }
}
