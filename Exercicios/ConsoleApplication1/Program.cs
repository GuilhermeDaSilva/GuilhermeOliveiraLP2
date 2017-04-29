using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Carro
        {
            public string modelo;
            public double km, mot;
            
        }                               
        static void Main(string[] args)
        {
            Carro car;
            int N, i;
            Console.WriteLine("Informe o número de carros no galpão");
            N = Convert.ToInt32(Console.ReadLine());
            
            string[] valores = new string[N];
                                    
            for (i = 0; i < N; i++)
            {               
                Console.WriteLine("Informe o modelo");
                car.modelo = Console.ReadLine();

                Console.WriteLine("Informe sua quilometragem");
                car.km = Double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potência do motor");
                car.mot = Double.Parse(Console.ReadLine());

                valores[i]= Classificar(car);                
            }
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("{0}", valores[i]);
            }        
        }
        static string Classificar(Carro paramet)
        {
            string tipo, tipod, tudo;
            if (paramet.km <= 5000)
            {
                tipo = "novo";
            }
            else if (paramet.km > 5000 && paramet.km <= 30000)
            {
                tipo = "seminovo";
            }
            else
            {
                tipo = "velho";
            }

            if (paramet.mot > 200)
            {
                tipod = "potente";
            }
            else if (paramet.mot >= 120 && paramet.mot <= 200)
            {
                tipod = "forte";
            }
            else
            {
                tipod = "popular";
            }
            tudo = paramet.modelo + " - " + tipo + " " + tipod;
            return tudo;            
        }
        
    }
}
