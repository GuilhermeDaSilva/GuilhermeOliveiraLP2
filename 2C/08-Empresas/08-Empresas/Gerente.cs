using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Gerente
    {
        private int registro;

        public string nome { get; set; }

        private int cpf;
       
        public string email { get; set; }
        
        public double sal { get; set; }
        
        public double bonus { get; set; }
        
        public string setor { get; set; }
        
        public Gerente(int registro, string nome, int cpf, string email, double sal, double bonus, string setor)
        {
            this.registro = registro;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sal = sal;
            this.bonus = bonus;
            this.setor = setor;
        }       
    }
}
