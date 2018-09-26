using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Animal's voice
        /// </summary>
        public abstract void Speak();

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        protected Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
