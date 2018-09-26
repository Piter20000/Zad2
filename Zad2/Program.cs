using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad2.Classes;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            var AAA = new Population();

            // Wyswietlenie probne 

            AAA.Display();

            // Wyswietlenie statystyk
            
            AAA.PrintNrInPopulation();

            Console.ReadLine();
        }

        
    }
}
