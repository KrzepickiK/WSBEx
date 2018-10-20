using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k30181020
{
    public class Kwadrat : Prostokat
    {

        public Kwadrat(float a) : base(a, a) { }

        public override string PrzedstawSie => "Kwadrat";
    }
}
