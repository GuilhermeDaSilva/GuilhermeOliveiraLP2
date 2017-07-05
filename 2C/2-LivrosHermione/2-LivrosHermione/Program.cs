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

            Livro[] obj = new Livro[n];

            for (int i = 0; i < n; i++)
            {
                obj[i].npag = int.Parse(Console.ReadLine());
                obj[i].diasdevol = int.Parse(Console.ReadLine());
                obj[i].titulo = Console.ReadLine();
                obj[n].calc(pph, hpd);
                int calcfinal = obj[n].calc(pph, hpd);
                Console.WriteLine(calcfinal);
            }            
            
            


            
            

        }
    }
}
