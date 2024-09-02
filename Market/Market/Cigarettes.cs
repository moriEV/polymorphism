using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class Cigarettes : Product
    {
        public enum Diseases
        {
            gangrene,
            impotence,
            insult,
            heart_attack,
            stillbirth,
            painful_death,
            prematurity,
            neoplasms,
            periodontal_disease,
            throat_cancer,
            lung_cancer,
            blindness
        }
        public Diseases Disease{  get; set; }
        public override double Price { get => base.Price * 0.99; }
        public override string getInformation()
        {
            return ($"Cigarettes {Name} with {Disease} costs {Price}$");
        }
    }
}
