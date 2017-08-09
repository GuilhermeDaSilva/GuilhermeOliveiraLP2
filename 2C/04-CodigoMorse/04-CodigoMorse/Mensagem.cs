using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Mensagem
    {
        private string[] tab = new string[] {
            ".-", "-...", "-.-.", "-..", ".", "..-.","--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
            "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };
        public string msg;
		public string Codificar()
        {
            for (int i=0;i<msg.Length;i++)
            {
                msg[i] = 'A' - msg[i];

            }
        }
		public string Decodificar()
        {
            
        }
		public string Transmitir()
        {

        }
    }
}
