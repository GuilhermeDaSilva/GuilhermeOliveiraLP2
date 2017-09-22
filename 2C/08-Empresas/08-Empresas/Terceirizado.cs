using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Terceirizado : Empregado
    {                
        public string empresa { get; set; }

        public Terceirizado(int registro, string nome, int cpf, string email, double sal, string data, string gerente, string empresa)
        {                        
            this.empresa = empresa;
        }
    }
}
