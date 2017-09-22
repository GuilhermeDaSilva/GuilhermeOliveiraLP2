using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Funcionario
    {
        private int registro;
        private int cpf;
        public int Registro { get { return registro; } }
        public int Cpf { get { return cpf; } }
        public string data { get; set; }
        public string nome { get; set; }        
        public string email { get; set; }
        public double sal { get; set; }

        public Funcionario(int registro, int cpf, string data, string nome, string email, double sal)
        {
            this.registro =registro;
            this.data = data;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sal = sal;
        }
        public Funcionario() { }
    }
}
