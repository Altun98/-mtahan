using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal13
    {
        public string ConvertWord(string word)
        {
            string convert = string.Empty;
            for (int i = word.Length-1; i >= 0; i--)
            {
                convert += word[i];
            }
            return convert;
        }
    }
}
