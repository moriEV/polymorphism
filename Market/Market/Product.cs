using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public abstract class Product
    {
        public string Name { get; set; }
        public virtual double Price { get; set; }
        public abstract string getInformation();
    }
}
