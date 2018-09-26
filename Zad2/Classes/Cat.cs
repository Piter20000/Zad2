using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Classes
{
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("\tCat's meow!");
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        public Cat(string Name, int Age) : base(Name, Age)
        {
        }
    }
}
