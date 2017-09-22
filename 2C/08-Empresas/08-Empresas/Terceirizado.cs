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

        public Terceirizado(string nome, string data, string Empresa) : base(nome, data)
        {                        
            Empresa = empresa;
        }
    }
}
