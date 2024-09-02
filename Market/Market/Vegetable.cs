using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Vegetable : Product
    {
        public double Weight { get; set; }
        public override double Price { get => base.Price * 0.6 * Weight; }
        public override string getInformation()
        {
            return ($"{Weight} kilograms of {Name} costs {Price}$");
        }
    }
}
