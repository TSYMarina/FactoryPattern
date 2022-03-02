using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class AnimalFactory 
    {
        public static IAnimals AnimalFinder(string coatType)
        {
            switch (coatType)
            {
                case "scales": 
                    return new Reptiles();
                case "fur":
                    return new FurryAnimals();
                case "feathers":
                    return new Birds();
                default:
                    return new FurryAnimals();
            }
         }

    }
}
