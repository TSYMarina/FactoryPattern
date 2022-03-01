using System;
namespace FactoryPattern

{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimals myNewAnimal = AnimalHabitat.AnimalFinder();
            myNewAnimal.BeHungry();
        }
    }
}