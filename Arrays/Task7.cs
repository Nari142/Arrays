using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Task7
    {
        public string TextCensor(string text, string censor)
        {
            int index = 0;
            string cens = "";
            if (text.IndexOf(censor) != -1)
            {
                for(int i = 0; i < censor.Length; i++)
                {
                    cens += "*";
                }
                text = text.Replace(censor, cens); 
            }
            return text;
        }
    }
}
