using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int pph = int.Parse(Console.ReadLine());
            int hpd = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());            
            string imp = "";

            Livro[] obj = new Livro[n];

            for (int i = 0; i < n; i++)
            {
                obj[i] = new Livro(); 
                obj[i].npag = int.Parse(Console.ReadLine());
                obj[i].diasdevol = int.Parse(Console.ReadLine());
                obj[i].titulo = Console.ReadLine();
                obj[i].calc(pph, hpd);
                int calcfinal = obj[i].calc(pph, hpd);

                Console.WriteLine(calcfinal + " dias necessários para ler o livro");

                if (obj[i].calc(pph, hpd) > obj[i].diasdevol)
                {
                    imp = imp + obj[i].titulo + " ";
                }
            }

            Console.WriteLine("Os livros impossíveis de ler são: " + imp);
        }
    }
}
