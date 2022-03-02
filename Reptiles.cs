using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Reptiles : IAnimals
    {
        public static void Scales()
        {
            Console.WriteLine("Congratulations! Your new lizard is crawling to you!");
        }

        public void BeHungry()
        {
            Console.WriteLine("Reptile is hungry");
        }
    }
}
