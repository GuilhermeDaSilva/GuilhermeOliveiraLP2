using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data,d,m,a;            
            Console.WriteLine("Informe uma data");data=(Console.ReadLine());
            d = data.Substring(0, 2);
            m = data.Substring(3, 2);
            a = data.Substring(6, 4);
            if (m == "01")
            {
                m = "Janeiro";
            }
            else if (m == "02")
            {
                m = "Fevereiro";
            }
            else if (m == "03")
            {
                m = "Março";
            }
            else if (m == "04")
            {
                m = "Abril";
            }
            else if (m == "05")
            {
                m = "Maio";
            }
            else if (m == "06")
            {
                m = "Junho";
            }
            else if (m == "07")
            {
                m = "Julho";
            }
            else if (m == "08")
            {
                m = "Agosto";
            }
            else if (m == "09")
            {
                m = "Setembro";
            }
            else if (m == "10")
            {
                m = "Outubro";
            }
            else if (m == "11")
            {
                m = "Novembro";
            }
            else
            {
                m = "Dezembro";
            }
            Console.WriteLine(d + " de " + m + " de " + a);


        }
    }
}
