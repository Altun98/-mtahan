using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class A
    {
        public abstract string B();
        public abstract string C();
    }
}

class MyClass : A
{
    public override string B()
    {
        throw new NotImplementedException();
    }

    public override string C()
    {
        throw new NotImplementedException();
    }
}
