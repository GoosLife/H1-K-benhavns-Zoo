using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1___Københavns_Zoo.Animals;
using H1___Københavns_Zoo.DatabaseSimulation;
using H1___Københavns_Zoo.Machines.Feeder;

namespace H1___Københavns_Zoo.Employees
{
    internal class ZooKeeper
    {
        private long id;
        private string name;

        public ZooKeeper(string name, int id)
        {
            this.id = id;
            this.name = name;
        }

        internal long ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        /// <summary>
        /// Button that zoo-keeper presses when feeding an animal.
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string FoodButton(Race race)
        {
            // Food buttons behavior changes depending on which animal is being fed.
            switch (race)
            {
                case Race.Hippo:
                    return Feeder.Instance.FoodButton(Food.Grass);
                case Race.Zebra:
                    return Feeder.Instance.FoodButton(Food.Grass);
                case Race.Tiger:
                    return Feeder.Instance.FoodButton(Food.Meat);
                default:
                    throw new ArgumentOutOfRangeException(nameof(race));
            }
        }
    }
}