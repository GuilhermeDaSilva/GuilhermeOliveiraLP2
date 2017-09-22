using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Gerente : Funcionario
    {        
        public double bonus { get; set; }       
        public string setor { get; set; }
        
        public Gerente(string nome, string setor) : base(nome)
        {            
            this.setor = setor;
        }       
    }
}
