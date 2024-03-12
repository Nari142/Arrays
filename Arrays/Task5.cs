using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Task5
    {
        public int arifmetStr(string arif_str)
        {
            if(arif_str.IndexOf("+") != -1)
            {
                
                string[] arif =arif_str.Split("+".ToCharArray());
                int sum = int.Parse(arif[0]);
                for (int i = 1; i < arif.Length; i++) sum += int.Parse(arif[i]);
                return sum;
            }
            else if(arif_str.IndexOf("-") != -1)
            {
                
                string[] arif = arif_str.Split("-".ToCharArray());
                int min = int.Parse(arif[0]);
                for (int i = 1; i < arif.Length; i++) min -= int.Parse(arif[i]);
                return min;
            }
            return 0;
        }
    }
}
