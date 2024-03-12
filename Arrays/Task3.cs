using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Arrays
{
    class Task3
    {
        public string alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private string CodeEncode(string text, int k)
        {
            string fullalf = alf + alf.ToLower();
            int letterQty = fullalf.Length;
            string resVal = "";
            for(int i = 0; i < text.Length; i++)
            {
                char temp = text[i];
                int index = fullalf.IndexOf(temp);
                if(index<0)
                {
                    resVal += temp.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    resVal += fullalf[codeIndex];
                }
            }
            return resVal;
        }

        public string Encrypt(string plainMessage, int key) => CodeEncode(plainMessage, key);

        public string Decrypt(string encryptedMessage, int key) => CodeEncode(encryptedMessage, -key);
    }
}
