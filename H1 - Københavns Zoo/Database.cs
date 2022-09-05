using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1___Københavns_Zoo.Animals;
using H1___Københavns_Zoo.Employees;

namespace H1___Københavns_Zoo.DatabaseSimulation
{
    internal sealed class Database
    {
        private static readonly Lazy<Database> database = new Lazy<Database>(() => new Database());

        private List<ZooKeeper> zooKeepers = new List<ZooKeeper>();
        private List<Animal> animals = new List<Animal>();

        public static Database Instance { get { return database.Value; } }

        public List<ZooKeeper> ZooKeepers
        {
            get { return zooKeepers; }
        }

        public List<Animal> Animals
        {
            get { return animals; }
        }
    }
}