using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{
    public class Cetaci : AAnimal
    {
        public Cetaci(string name, string breed, float weight) : base(name, breed, weight) { this.SuperFamily = "Cetaci        "; }
        public override int CalcGA(double GA, int x)
        {
            return Convert.ToInt32(GA - (Math.Log10(GA) -x));
        }

    }
}
