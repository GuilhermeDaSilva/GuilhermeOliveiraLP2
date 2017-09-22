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
        
        public Gerente(int registro, string nome, int cpf, string email, double sal, double bonus, string setor)
        {            
            this.bonus = bonus;
            this.setor = setor;
        }       
    }
}
