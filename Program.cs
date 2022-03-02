using System;
namespace FactoryPattern

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of coat should your animal have?");
            string coatType = Console.ReadLine();

            IAnimals animalHabitat = AnimalFactory.AnimalFinder(coatType);
            animalHabitat.BeHungry();
        }
    }
}