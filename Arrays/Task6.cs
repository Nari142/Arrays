using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Task6
    {
        public string TitleStr(string str)
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            if (str.IndexOf('.') != -1)
            {
                string sum_str = "";
                string[] arr_str = str.Split('.');
                for(int i = 0; i < arr_str.Length; i++)
                {
                    string items = "";
                    string[] strings = arr_str[i].Split(new char[] { ' ' });
                    if (strings[0].IndexOf("") != -1) strings = strings.Where(e => e != items).ToArray();
                    for (int j = 0; j < strings.Length; j++)
                    {
                        
                        if (j == 0) strings[j] = ti.ToTitleCase(strings[j]);
                    }
                    sum_str += string.Join(" ", strings) + ". ";
                }
                
                return sum_str;
            }
            return ti.ToTitleCase(str);
        }
    }
}
