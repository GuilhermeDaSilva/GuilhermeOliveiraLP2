using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoEmPlano2D
{
    class Objeto2D
    {
        public int x;
        public int y;
        public void AndarParaADireita()
        {
            x=x+3;
        }
        public string Coordenadas()
        {
            return String.Format("[{0},{1}]", x, y);
        }
    }

}
