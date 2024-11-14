using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal3<T,K>
    {
        public T First { get; set; }
        public K Second { get; set; }

        public void Print()
        {
            Console.WriteLine($"{First} {Second}");
        }

    }
}
