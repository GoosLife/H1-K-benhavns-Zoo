using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1___Københavns_Zoo.Animals;
using H1___Københavns_Zoo.DatabaseSimulation;
using H1___Københavns_Zoo.Employees;

namespace H1___Københavns_Zoo
{
    internal sealed class DatabaseAccessor
    {
        private static readonly Lazy<DatabaseAccessor> generator = new Lazy<DatabaseAccessor>(() => new DatabaseAccessor());

        public static DatabaseAccessor Instance { get { return generator.Value; } }

        /// <summary>
        /// Returns a string containing all zoo keepers and their IDs.
        /// </summary>
        /// <returns></returns>
        internal string GetAllZooKeepers()
        {
            string output = "";

            foreach (ZooKeeper z in Database.Instance.ZooKeepers)
            {
                output += z.ID + " " + z.Name + '\n';
            }

            return output;
        }
        
        /// <summary>
        /// Returns a specific zoo keeper or a list of zoo keepers whose names contains the string specified in the name parameter.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal string GetZooKeepersByName(string name)
        {
            string output = "";
            List<ZooKeeper> results = Database.Instance.ZooKeepers.FindAll(x => x.Name.Contains(name));

            foreach (ZooKeeper z in results)
            {
                output += z.ID + " " + z.Name + '\n';
            }

            return output;
        }
    }
}
