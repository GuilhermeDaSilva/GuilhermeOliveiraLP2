using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorridaI
{
    class Comp
    {
        public double prim;
        public double seg;
        public double terc;
        public string nome;
        
        public double contaf()
        {
            double[] tempos = new double[3] { prim, seg, terc };
            Array.Sort(tempos);
            double tudo = tempos[0] + tempos[1];
            return tudo;
        }
    }
}
