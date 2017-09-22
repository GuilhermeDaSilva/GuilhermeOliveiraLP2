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
        public string nome { get; set; }        
        public string email { get; set; }
        public double Salario { get; set; }
        public Funcionario(string nome)
        {
            this.nome = nome;
        }
        public Funcionario() { }
    }
}
