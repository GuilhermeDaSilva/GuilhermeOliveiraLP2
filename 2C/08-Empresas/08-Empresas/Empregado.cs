using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Empregado
    {
        private int registro { get; set; }

        private string nome { get; set; }

        private int cpf { get; set; }
       
        private string email { get; set; }
        
        private double sal { get; set; }

        private string data { get; set; }

        private string gerente { get; set; }

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
        public string Info()
        {
            return String.Format("Nome do(a) Empregado(a): {0}.", nome);
        }
    }
}
