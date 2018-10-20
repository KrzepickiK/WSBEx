using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k30181020
{
    public class Prostokat : Figura
    {
        private float a;
        private float b;

        public Prostokat()
        {
            a = 0.0f;
            b = 0.0f;
        }

        public Prostokat(float a, float b) : this()
        {
            this.a = a;
            this.b = b;
        }
        public override string PrzedstawSie
        {
            get
            {
                return "Prostokąt";
            }
        }

        public override float Pole
        {
            get
            {
                return a * b;
            }
        }

//        public override float Obwod
//        {
//            get
//            {
//                return (2 * a + 2 * b);
//            }
//        }
//
        public override float Obwod => 2 * a + 2 * b;
    }
}
