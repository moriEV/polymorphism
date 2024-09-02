using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{

    public class Meat : Product
    {
        public enum DegreeOfDoneness
        {
            Rare,
            MediumRare,
            Medium,
            MediumWell,
            WellDone
        }

        public DegreeOfDoneness Doneness { get; set; }

        public override double Price { get => base.Price * 0.7; }

        public override string getInformation()
        {
            return ($"Meat {Name} with {Doneness} costs {Price}$");
        }
    }
}
