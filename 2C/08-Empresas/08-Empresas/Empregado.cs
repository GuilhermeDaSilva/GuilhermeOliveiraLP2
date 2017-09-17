using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Empregado
    {
        private int registro;

        public string nome { get; set; }

        private int cpf;
       
        public string email { get; set; }
        
        public double sal { get; set; }

        public string data { get; set; }

        public string gerente { get; set; }

        public Empregado(int registro, string nome, int cpf, string email, double sal, string data, string gerente)
        {
            this.registro = registro;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sal = sal;
            this.data = data;
            this.gerente = gerente;
        }        
    }
}
