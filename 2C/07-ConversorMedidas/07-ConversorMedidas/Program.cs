using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(Conversor.CParaF(120));
            Console.WriteLine(Conversor.FtParaM(270));
            Console.WriteLine(Conversor.MParaKm(890));
            Console.WriteLine(Conversor.KmParaMi(29));
            Console.WriteLine(Conversor.InParaFt(78));
            Console.WriteLine(Conversor.KgParaG(80));
        }
    }
}
