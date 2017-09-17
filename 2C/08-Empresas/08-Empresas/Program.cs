using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresas
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente x = new Gerente(001, "Ani", 280967-0, "Ani@gmail.com", 800, 200, "alimentos");
            Console.WriteLine(x.Info());

            Terceirizado y = new Terceirizado(002, "Caio", 280967-1, "Caio@gmail.com", 600, "Três de Setembro de 1986", "Ani", "Casas Bahia");
            Console.WriteLine(y.Info());

            Empregado z = new Empregado(003, "Bruno", 280967 - 2, "Bruno@gmail.com", 1000, "Quatro de Dezembro de 1990", "Ani");
            Console.WriteLine(z.Info());
        }
    }
}
