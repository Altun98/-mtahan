using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal16
    {
        public void elementsAdd(int n)
        {
            List<int> _items = new List<int>();
            Random rt = new Random();
            int i = 0;
            while (i < n)
            {
                _items.Add(rt.Next(18));
                Console.WriteLine(_items[i]);
                i++;
            }
           
        }
    }
}
