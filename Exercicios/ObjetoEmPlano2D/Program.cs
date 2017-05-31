using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoEmPlano2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y incial: ");
            int y = int.Parse(Console.ReadLine());

            while (true)
            {
                Objeto2D obj = new Objeto2D();
                obj.x = x;
                obj.y = y;
                Console.Write("Digite comando");
                ConsoleKey comando = Console.ReadKey().Key;

                if (comando == ConsoleKey.RightArrow)
                {
                    obj.AndarParaADireita();
                    Console.WriteLine(obj.Coordenadas());
                }
            }
        }
    }
}
