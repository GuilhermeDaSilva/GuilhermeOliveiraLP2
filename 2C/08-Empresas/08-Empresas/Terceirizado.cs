using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Terceirizado
    {
        private int registro { get; set; }

        private string nome { get; set; }

        private int cpf { get; set; }
       
        private string email { get; set; }
        
        private double sal { get; set; }

        private string data { get; set; }

        private string gerente { get; set; }

        private string empresa { get; set; }

        public Terceirizado(int registro, string nome, int cpf, string email, double sal, string data, string gerente, string empresa)
        {
            this.registro = registro;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.sal = sal;
            this.data = data;
            this.gerente = gerente;
            this.empresa = empresa;
        }
        public string Info()
        {
            return String.Format("Nome do(a) Terceirizado(a): {0}.", nome);
        }
    }
}
