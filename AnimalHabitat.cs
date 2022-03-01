using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AnimalHabitat : IAnimals
    {
        public static IAnimals AnimalFinder()
        {
            Console.WriteLine("What kind of coat should your animal have?");
            var answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "scales": 
                    return new HaveScales();
                case "fur":
                    return new HaveFur();
                default:
                    return new HaveFur();
            }
         }

        public void BeHungry()
        {
            
        }
    }
}
