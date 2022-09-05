using System;
using H1___Københavns_Zoo.Generators;

namespace H1___Københavns_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run once to ensure ZooGenerator singleton is initialized.
            if (!ZooGenerator.Instance.IsInstantiated())
            {
                Console.WriteLine("Zoo failed to generate.");
                return;
            }

            // I can access the employees and output them to console
            Console.WriteLine(DatabaseAccessor.Instance.GetAllZooKeepers());

            // But I cannot access any zoo keeper properties or methods, because this class doesn't know the zoo keeper class.
            // ZooKeeper z = new ZooKeeper()
            // z.Name = "New name";
            Console.ReadKey();
        }
    }
}
