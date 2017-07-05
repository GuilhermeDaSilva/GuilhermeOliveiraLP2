using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a data");
            string[] datatoda = Console.ReadLine().Split(' ');
            string mesdata = datatoda[2].ToUpper();            
            int diadata = int.Parse(datatoda[0]);
            int total;

            switch (mesdata)
            {
                case "JANEIRO":
                    {
                        mesdata = "1";
                        break;
                    }
                case "FEVEREIRO":
                    {
                        mesdata = "2";
                        break;
                    }
                case "MARÇO":
                    {
                        mesdata = "3";
                        break;
                    }
                case "ABRIL":
                    {
                        mesdata = "4";
                        break;
                    }
                case "MAIO":
                    {
                        mesdata = "5";
                        break;
                    }
                case "JUNHO":
                    {
                        mesdata = "6";
                        break;
                    }
                case "JULHO":
                    {
                        mesdata = "7";
                        break;
                    }
                case "AGOSTO":
                    {
                        mesdata = "8";
                        break;
                    }
                case "SETEMBRO":
                    {
                        mesdata = "9";
                        break;
                    }
                case "OUTUBRO":
                    {
                        mesdata = "10";
                        break;
                    }
                case "NOVEMBRO":
                    {
                        mesdata = "11";
                        break;
                    }
                case "DEZEMBRO":
                    {
                        mesdata = "12";
                        break;
                    }
            }

            if (mesdata == "1")
            {
                total = diadata;
                Console.WriteLine("{0} º dia do ano", total);  
            }
            else if (mesdata == "2")
            {
                total = diadata + 31;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "3")
            {
                total = diadata + 59;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "4")
            {
                total = diadata + 90;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "5")
            {
                total = diadata + 120;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "6")
            {
                total = diadata + 151;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "7")
            {
                total = diadata + 181;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "8")
            {
                total = diadata + 212;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "9")
            {
                total = diadata + 243;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "10")
            {
                total = diadata + 273;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "11")
            {
                total = diadata + 304;
                Console.WriteLine("{0} º dia do ano", total);
            }
            else if (mesdata == "12")
            {
                total = diadata + 334;
                Console.WriteLine("{0} º dia do ano", total);
            }
        }
    }
}
