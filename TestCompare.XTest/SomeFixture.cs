using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCompare.XTest
{
    public class SomeFixture:IDisposable
    {
        public int count { get; private set; }
        public SomeFixture()
        {
            Console.WriteLine("SomeFixture ctor: This should only be run once");
        }

        public void SomeMethod()
        {
            this.count++;
            Console.WriteLine("SomeFixture::SomeMethod()");
        }

        public void Dispose()
        {
            this.count = 0;
            Console.WriteLine("I will be called when disposable");
        }
    }
}
