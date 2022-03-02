using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Birds : IAnimals
    {
        
        public void BeHungry()
        {
            Console.WriteLine("Bird is hungry");
        }
    }
}
