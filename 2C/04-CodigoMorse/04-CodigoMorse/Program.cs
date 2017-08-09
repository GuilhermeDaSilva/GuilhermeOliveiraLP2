using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Mensagem ord = new Mensagem();
            ord.msg = Console.ReadLine();
            if (n == '1')
            {
                ord.Codificar();
            }
            else if (n == '2')
            {
                ord.Decodificar();
            }
            else if (n == '3')
            {
                ord.Transmitir();
            }
            else
            {
                Console.WriteLine("inválido");
            }

        }
    }
}
