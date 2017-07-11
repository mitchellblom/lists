using System.Collections.Generic;

using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){"Uranus", "Neptune"};

            foreach (string planet in planetList) {
                Console.WriteLine(planet);
            }

            List<string> newPlanetList = new List<string>();
            newPlanetList.AddRange(planetList);
            newPlanetList.AddRange(lastPlanets);

            Console.WriteLine("newPlanetList below: ");
            foreach (string planet in newPlanetList) {
                Console.WriteLine(planet);
            }

            newPlanetList.Insert(1, "Venus");
            newPlanetList.Insert(2, "Earth");

            newPlanetList.Add("Pluto");

            Console.WriteLine("with Venus, Earth, and Pluto: ");
            foreach (string planet in newPlanetList) {
                Console.WriteLine(planet);
            }

            List<string> rockyPlanets = new List<string>(newPlanetList).GetRange(0,4);

            Console.WriteLine("Rocky Planets: ");
            foreach (string planet in rockyPlanets) {
                Console.WriteLine(planet);
            }

            newPlanetList.Remove("Pluto");

            Console.WriteLine("Without Pluto: ");
            foreach (string planet in newPlanetList) {
                Console.WriteLine(planet);
            }

        }

    }
}