using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Toy : Product
    {
        public int AgeGroup { get; set; }
        public override double Price {get => base.Price * 0.85; }
        public override string getInformation()
        {
            return($"Toy {Name} for {AgeGroup} years old costs {Price}$");
        }
    }
}
