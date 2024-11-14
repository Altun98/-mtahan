using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CollectionWrapper<T>
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
        public void displyall()
        {
            foreach (var x in items)
            {
                Console.WriteLine(x);
            }

        }
    }
}
