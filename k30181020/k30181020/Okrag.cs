using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k30181020
{
    class Okrag : Figura
    {
        private float r;

        public Okrag(float r=0.0f)
        {
            this.r = r;
        }

        public override float Pole => (float)Math.PI * (float)Math.Pow(r, 2);

        public override float Obwod => (float)(2.0 * Math.PI * r);
        //public override string PrzedstawSie
        //{
        //    get
        //    {
        //        return "Okrąg";
        //    }
        //}

        public override string PrzedstawSie => "Okrąg";
    }
}
