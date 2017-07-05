using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {              
                double A = Double.Parse(Console.ReadLine());
                double B = Double.Parse(Console.ReadLine());
                double C = Double.Parse(Console.ReadLine());
                double D = Double.Parse(Console.ReadLine());
                double E = Double.Parse(Console.ReadLine());

                if (A <= 100 && B >= 155 && C >= 155 && D >= 155 && E >= 155) { Console.WriteLine("A"); }
                else if (B <= 100 && A >= 155 && C >= 155 && D >= 155 && E >= 155) { Console.WriteLine("B"); }
                else if (C <= 100 && A >= 155 && B >= 155 && D >= 155 && E >= 155) { Console.WriteLine("C"); }
                else if (D <= 100 && A >= 155 && B >= 155 && C >= 155 && E >= 155) { Console.WriteLine("D"); }
                else if (E <= 100 && A >= 155 && B >= 155 && C >= 155 && D >= 155) { Console.WriteLine("E"); }

                else { Console.WriteLine("*"); }
            }
        }
    }
}
