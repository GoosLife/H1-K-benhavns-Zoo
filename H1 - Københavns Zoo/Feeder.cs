using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1___Københavns_Zoo.Machines.Feeder
{
    enum Food
    {
        Meat,
        Corn,
        Bananas,
        Grass
    }

    /// <summary>
    /// Singleton food dispenser class
    /// </summary>
    internal sealed class Feeder
    {
        private static readonly Lazy<Feeder> feeder = new Lazy<Feeder>(() => new Feeder());

        public static Feeder Instance { get { return feeder.Value; } }

        /// <summary>
        /// The method that runs when a zoo-keeper presses the feed button.
        /// </summary>
        /// <returns></returns>
        internal string FoodButton(Food foodToDispense)
        {
            return foodToDispense.ToString().ToLower() + " was released from the machine.";
        }
    }
}
