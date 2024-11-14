using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Misal6
    {
        public void Print()
        {
            Dictionary<string, double> frite = new Dictionary<string, double>();
            frite.Add("Alma", 10.23);
            frite.Add("Armud", 20.56);
            frite.Add("Banan", 15);
            frite.Add("Nar", 25);

            foreach (var item in frite)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
