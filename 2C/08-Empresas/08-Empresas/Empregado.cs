using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Empregado : Funcionario
    {
        private string data;
        public Gerente chefe { get; set; }
        public string Data { get { return data; } }       

        public Empregado(string nome, string data)
        {
            this.data = data;
        }
        public Empregado() { }
    }
}
