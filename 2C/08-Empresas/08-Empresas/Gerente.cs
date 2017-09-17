using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Gerente
    {
        private int registro { get; set; }

        private string nome { get; set; }

        private int cpf { get; set; }
       
        private string email { get; set; }
        
        private double sal { get; set; }
        
        private double bonus { get; set; }
        
        private string setor { get; set; }
        
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
        public string Info()
        {
            return String.Format("Nome do(a) Gerente: {0}.", nome);
        }
    }
}
