using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1___Københavns_Zoo.DatabaseSimulation;

namespace H1___Københavns_Zoo.Employees
{
    internal class HR
    {
        private void ChangeZooKeeperName(int id, string name)
        {
            int index = Database.Instance.ZooKeepers.FindIndex(x => x.ID == id);
            Database.Instance.ZooKeepers[index].Name = name;
        }
    }
}
