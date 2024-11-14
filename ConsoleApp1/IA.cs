using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IA
    {
        public void M();
        public void N();
    }
    class MyClass : IA
    {
        public void M()
        {
            throw new NotImplementedException();
        }

        public void N()
        {
            throw new NotImplementedException();
        }
    }
}
