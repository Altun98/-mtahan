using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal9
    {

        public IEnumerable<int> number3(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                    yield return i;
            }

        }
    }
}