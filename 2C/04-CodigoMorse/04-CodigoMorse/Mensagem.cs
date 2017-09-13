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
            string res = "";
            for (int i=0;i<msg.Length;i++)
            {
                if (msg[i] == ' ')
                {
                    res += "\t";
                }
                else
                {
                    res += String.Format("{0} ", tab[msg[i] - 'A']);
                }
            }
            return res;
        }
		public string Decodificar()
        {
            string[] quebrada = msg.Split(' ');
            string res = "";
                           
            for (int i = 0; i < quebrada.Length; i++)
            {
                if (quebrada[i] == "\t")
                {
                    res += " ";
                }
                else
                {
                    int index = Array.IndexOf(tab, quebrada[i]);
                    char ch = (char)(index + 'A');
                    res += String.Format("{0}", ch);
                }
                
            }
           
            return res;
        }

		public string Transmitir()
        {
            return "";
        }
    }
}
