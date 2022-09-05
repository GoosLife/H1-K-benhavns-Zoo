using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1___Københavns_Zoo.Employees;
using H1___Københavns_Zoo.Animals;
using H1___Københavns_Zoo.DatabaseSimulation;

namespace H1___Københavns_Zoo.Generators
{
    internal sealed class ZooGenerator
    {
        private ZooGenerator(bool generateZoo) { GenerateZoo(); }

        private static readonly Lazy<ZooGenerator> generator = new Lazy<ZooGenerator>(() => new ZooGenerator(true));

        public static ZooGenerator Instance { get { return generator.Value; } }

        private void GenerateZoo()
        {
            GenerateEmployees();
            GenerateAnimals();
        }

        private void GenerateEmployees()
        {
            for (int i = 0; i < 15; i++)
            {
                ZooKeeper z = new ZooKeeper("Zoo Keeper", i);
                Database.Instance.ZooKeepers.Add(z);
            }
        }

        private void GenerateAnimals()
        {
            for (int i = 0; i < 20; i++)
            {
                // Oneliner version, overwritten for readability
                // Database.Instance.Animals.Add(
                //     new Animal(
                //         (Race)new Random().Next(Enum.GetValues(typeof(Race)).Length), 
                //         (Gender)new Random().Next(Enum.GetValues(typeof(Gender)).Length)
                //         )
                //     );

                Random r = new Random();

                // Get the number of races and genders by counting the total amount of values found in the enum.
                int numberOfRaces = Enum.GetValues(typeof(Race)).Length;
                int numberOfGenders = Enum.GetValues(typeof(Gender)).Length;

                Race randomRace = (Race)r.Next(numberOfRaces); // Draw random race.
                Gender randomGender = (Gender)r.Next(numberOfGenders);

                Animal a = new Animal(randomRace, randomGender);

                Database.Instance.Animals.Add(a);
            }
        }

        /// <summary>
        /// Ensure this singleton has been instantiated once
        /// </summary>
        /// <returns></returns>
        public bool IsInstantiated() 
        {
            return Instance != null; // Return true if the instance is NOT null.
        }
    }
}
