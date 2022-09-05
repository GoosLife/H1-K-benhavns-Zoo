using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1___Københavns_Zoo.Animals
{
    public enum Race
    {
        Zebra,
        Tiger,
        Hippo
    }

    public enum Gender
    {
        Male,
        Female
    }

    internal class Animal
    {
        private Race race;
        private Gender gender;

        internal Animal(Race race, Gender gender)
        {
            this.race = race;
            this.gender = gender;
        }
        
        /// <summary>
        /// Animal drinks
        /// </summary>
        /// <returns></returns>
        public string Drink()
        {
            return race + " drank";
        }

        /// <summary>
        /// Animal eats
        /// </summary>
        /// <returns></returns>
        public string Eat()
        {
            return race + " ate";
        }
    }
}
