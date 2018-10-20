using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k30181020
{
    public abstract class Figura : IPrzedstawSie
    {
        public static int LiczbaInstancji { get; private set; }
        public Figura()
        {
            LiczbaInstancji++;
        }
        public virtual float Pole
        {
            get
            {
                return 0.0f;
            }
        }

        public virtual float Obwod
        {
            get
            {
                return 0.0f;
            }
        }

        public virtual string PrzedstawSie
        {
            get;
        }

        public override string ToString()
        {
            return $"{PrzedstawSie} Pole={Pole} Obwód={Obwod}";
        }

    }
}
