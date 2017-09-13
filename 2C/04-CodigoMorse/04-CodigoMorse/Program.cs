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
            Mensagem ord = new Mensagem();
            ord.msg = Console.ReadLine();
            string n = Console.ReadLine();
            
            if (n == "1")
            {
                Console.WriteLine(ord.Codificar());
            }
            else if (n == "2")
            {
                Console.WriteLine(ord.Decodificar());
            }

        }
    }
}
