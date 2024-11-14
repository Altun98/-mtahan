using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MIsal8
    {
        public void Print()
        {
            HashSet<string> hasLis = new HashSet<string>();
            hasLis.Add("Alma");
            hasLis.Add("Banan");
            hasLis.Add("Apensin");
            hasLis.Add("Alma"); // 

            foreach (var lis in hasLis)
            {
                Console.WriteLine(lis);
            }
            if (hasLis.Contains("Apensin") || hasLis.Contains("Banan"))
            {
                Console.WriteLine("Siyahida var");
            }
            else { Console.WriteLine("Siyahida yoxdur"); }

            hasLis.Remove("Alma");
            foreach (var lis in hasLis)
            {
                Console.WriteLine(lis);
            }
        }



    }
}
