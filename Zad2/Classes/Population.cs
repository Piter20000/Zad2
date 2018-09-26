using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2.Classes
{
    class Population
    {
        private List<Animal> Animals;

        #region Constructor

        /// <summary>
        /// Class Constructor
        /// </summary>
        public Population()
        {
            Animals = GenerateAnimals();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method generate list of animals
        /// </summary>
        /// <returns></returns>
        private List<Animal> GenerateAnimals()
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
        public void Display()
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
        /// <returns></returns>
        public int Get_Number_Of_Cats()
        {
            var cats = Animals.OfType<Cat>();

            return cats.Count();
        }

        /// <summary>
        /// Method return number of dogs
        /// </summary>
        /// <returns></returns>
        public int Get_Number_Of_Dogs()
        {
            var dogs = Animals.OfType<Dog>();

            return dogs.Count();
        }

        /// <summary>
        /// Method return number of animals
        /// </summary>
        /// <returns></returns>
        public int Get_Number_Of_Animals()
        {
            return Animals.Count;
        }

        public void PrintNrInPopulation()
        {
            Console.WriteLine("\n\t\t### Statistics ###");
            Console.WriteLine("\n\tTotal animals in population: " + Get_Number_Of_Animals());

            Console.WriteLine();

            Console.WriteLine("\tCats: " + Get_Number_Of_Cats());
            Console.WriteLine("\tDogs: " + Get_Number_Of_Dogs());

            Console.WriteLine();

            int nr = 1;
            foreach (var animal in Animals)
            {
                Console.WriteLine($"\tAnimal: {animal.GetType().Name}, number in population: {nr}");
                nr++;
            }
        }

        #endregion

    }
}
