using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class HaveFur : IAnimals
    {
        public static void Furries()
        {
            Console.WriteLine("Congratulations! Your new furry friend is coming.");
        }

        public void BeHungry()
        {
            Console.WriteLine("Please get some tuna fish for your new kitty.");
        }

    }
}
