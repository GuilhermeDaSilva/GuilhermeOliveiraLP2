using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string modelo,valores;
            double km, mot;

            Console.WriteLine("Informe o número de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());
                                    
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Informe o modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                mot = Double.Parse(Console.ReadLine());

                valores= Classificar(modelo,km,mot);
                
                Console.WriteLine("{0}",valores);
            }

        }
        static string Classificar(string mod, double klm, double motorpot)
        {
            string tipo, tipod, tudo;
            if (klm <= 5000)
            {
                tipo = "novo";
            }
            else if (klm > 5000 && klm <= 30000)
            {
                tipo = "seminovo";
            }
            else
            {
                tipo = "velho";
            }

            if (motorpot > 200)
            {
                tipod = "potente";
            }
            else if (motorpot >= 120 && motorpot <= 200)
            {
                tipod = "forte";
            }
            else
            {
                tipod = "popular";
            }
            tudo = mod + " - " + tipo + " " + tipod;
            return tudo;            
        }
    }
}
