using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal1
    {
        public List<int> GetList1(int[] _array, int m)
        {
            List<int> _items = new List<int>();
            _items.AddRange(_array);
           
            for (int i =_items.Count-1; i > m; i--)
            {
                _items.Remove(_items[i]);
            }
            return _items;
        }
    }
}
