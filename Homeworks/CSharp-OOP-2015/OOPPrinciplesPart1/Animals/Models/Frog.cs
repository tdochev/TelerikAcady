﻿namespace Animals.Models
{
    class Frog : Animal
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.AnimalKind = AnimalKind.Frog;
        }

        public override string ProduceSound()
        {
            return "Ribbit, ribbit!";
        }
    }
}