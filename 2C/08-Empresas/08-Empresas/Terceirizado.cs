using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Terceirizado
    {
        private int registro;

        public string nome { get; set; }

        private int cpf;
       
        public string email { get; set; }
        
        public double sal { get; set; }

        public string data { get; set; }

        public string gerente { get; set; }

        public string empresa { get; set; }

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
    }
}
