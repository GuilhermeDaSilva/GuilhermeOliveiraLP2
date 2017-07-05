using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Livro
    {
        public string titulo;
        public int npag;
        public int diasdevol;       

        public int calc (int pph, int hpd)
        {            
            int pagspdia = pph * hpd;
            int calcf = npag / pagspdia;
            return calcf;
        }

    }
}
