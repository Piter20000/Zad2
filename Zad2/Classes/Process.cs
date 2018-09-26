using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Classes
{
    class Process
    {
        /// <summary>
        /// Method generate list of animals
        /// </summary>
        /// <returns></returns>
        public List<Animal> GenerateAnimals()
        {
            List<Animal> Animals = new List<Animal>();

            Animals.Add(new Cat("Filemon", 4));
            Animals.Add(new Dog("Brutus", 11));
            Animals.Add(new Cat("Wanda", 5));
            Animals.Add(new Dog("Felek", 12));
            Animals.Add(new Dog("Felek", 12));

            return Animals;
        }

        /// <summary>
        /// Method display animal's voice from list of animals 
        /// </summary>
        /// <param name="Animals"></param>
        public void Display(ref List<Animal> Animals)
        {
            Console.WriteLine("\n\t\t### Voice test ###\n");
            foreach (var animal in Animals)
            {
                Console.WriteLine();
                animal.Speak();
            }
        }

        /// <summary>
        /// Method return number of cats
        /// </summary>
        /// <param name="Animals"></param>
        /// <returns></returns>
        public int Get_Number_Of_Cats(ref List<Animal> Animals)
        {
            var cats = Animals.OfType<Cat>();

            return cats.Count();
        }

        /// <summary>
        /// Method return number of dogs
        /// </summary>
        /// <param name="Animals"></param>
        /// <returns></returns>
        public int Get_Number_Of_Dogs(ref List<Animal> Animals)
        {
            var dogs = Animals.OfType<Dog>();

            return dogs.Count();
        }

        /// <summary>
        /// Method return number of animals
        /// </summary>
        /// <param name="Animals"></param>
        /// <returns></returns>
        public int Get_Number_Of_Animals(ref List<Animal> Animals)
        {
            return Animals.Count;
        }

        public void PrintNrInPopulation(ref List<Animal> Animals)
        {
            Console.WriteLine("\n\t\t### Statistics ###");
            Console.WriteLine("\n\tTotal animals in population: " + Get_Number_Of_Animals(ref Animals));

            Console.WriteLine();

            Console.WriteLine("\tCats: " + Get_Number_Of_Cats(ref Animals));
            Console.WriteLine("\tDogs: " + Get_Number_Of_Dogs(ref Animals));

            Console.WriteLine();

            int nr = 1;
            foreach (var animal in Animals)
            {
                Console.WriteLine($"\tAnimal: {animal.GetType().Name}, number in population: {nr}");
                nr++;
            }
        }
    }
}
