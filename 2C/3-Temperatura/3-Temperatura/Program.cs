using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturaCelsius obj = new TemperaturaCelsius();
            obj.temp = 0;
            obj.temp = double.Parse(Console.ReadLine());
            double receberF = obj.ParaFahrenheit();            
            double receberK = obj.ParaKelvin();
            Console.WriteLine("{0}ºF e {1}K",receberF,receberK);
        }
    }
}
