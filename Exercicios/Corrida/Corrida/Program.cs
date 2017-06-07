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
            int no = Convert.ToInt32(Console.ReadLine());
            Comp[] comps = new Comp[no];
            int i;           
            for (i=0;i<no;i++)
            {
                comps[i] = new Comp();
                comps[i].nome = Console.ReadLine();
            }
            for (i=0;i<no;i++)
            {
                Console.WriteLine("Informe o tempo da primeira etapa");
                comps[i].prim = Convert.ToInt32(Console.ReadLine());            
                Console.WriteLine("Informe o tempo da segunda etapa");
                comps[i].seg = Double.Parse(Console.ReadLine());                                    
                Console.WriteLine("Informe o tempo da terceira etapa");
                comps[i].terc = Double.Parse(Console.ReadLine());
            }

            
//O CPII vai organizar uma competição de corrida, em várias provas de 100m rasos.
//Cada competidor correrá 3 vezes, e poderá descartar seu pior tempo. A soma dos
//outros dois tempos dará o tempo oficial do competidor, e o competidor com o menor 
//tempo oficial será o campeão
//Tarefa: Dadas as informações sobre os competidores (nome e tempos), determine quem é 
//o campeão da competição

            
        }
    }
}
