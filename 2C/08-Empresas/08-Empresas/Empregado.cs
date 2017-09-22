using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Empregado : Funcionario
    {
       
        public string gerente { get; set; }

        public Empregado(int registro, string nome, int cpf, string email, double sal, string data, string gerente)
        {            
            this.gerente = gerente;
        }
        public Empregado() { }
    }
}
