using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            Triangulo tr = new Triangulo();
            Console.WriteLine(tr.area(b, h));
        }
        
    }
}
