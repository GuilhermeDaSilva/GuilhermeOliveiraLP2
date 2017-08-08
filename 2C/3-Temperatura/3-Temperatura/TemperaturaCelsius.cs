using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Temperatura
{
    class TemperaturaCelsius
    {
        public double temp;

        public double ParaFahrenheit() 
        {
            double f = (9*temp + 160)/5;
            return f;
        }  

        public double ParaKelvin()
        {
            double k = temp + 273;
            return k;
        }
    }    
}
