using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Drinks : Product
    {
        public bool alcohol {  get; set; }
        public override double Price { get => base.Price * 1; }
        public override string getInformation()
        {
            if (alcohol)
                    return ($"alcohol drink {Name} costs {Price}$");
            else
                return ($"Not alcohol drink {Name} costs {Price}$");
        }
    }
}
