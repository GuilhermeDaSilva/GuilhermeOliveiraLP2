using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Program
    {
        static void Main(string[] args)
        {            
            int no = int.Parse(Console.ReadLine());
            Comp[] comps = new Comp[no];           
            int i;
            double Tempomenos = double.MaxValue;
            string vencedor;
            for (i=0;i<no;i++)
            {
                comps[i] = new Comp();
                comps[i].nome = Console.ReadLine();
            }
            for (i=0;i<no;i++)
            {
                Console.WriteLine("Informe o tempo da primeira etapa do competidor {0}",comps[i].nome);
                comps[i].prim = Convert.ToInt32(Console.ReadLine());  
          
                Console.WriteLine("Informe o tempo da segunda etapa do competidor {0}",comps[i].nome);
                comps[i].seg = Double.Parse(Console.ReadLine()); 
                                   
                Console.WriteLine("Informe o tempo da terceira etapa do competidor {0}",comps[i].nome);
                comps[i].terc = Double.Parse(Console.ReadLine());                                
            }
            for (i = 0; i < no; i++)
            {
                if (comps[i].contafinal() < Tempomenos)
                {
                    Tempomenos = comps[i].contafinal();
                    vencedor = comps[i].nome;   
                }
            }
            Console.WriteLine("{0}", vencedor);       
        }
    }
}
