using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Classes
{
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("\tDog's howl");
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        public Dog(string Name, int Age) : base(Name, Age)
        {
        }
    }
}
