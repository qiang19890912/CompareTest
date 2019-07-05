using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace TestCompare.XTest
{
    public class XUnitIFxtureDemo: IClassFixture<SomeFixture>,IDisposable
    {
        private SomeFixture data;

         
        public XUnitIFxtureDemo()
        {
            //this data will be same instance in this class
            //this.data = data;
            Console.WriteLine("This should be run once before every test " + DateTime.Now.Ticks);
        }

        [Fact]
        public void Test1()
        {
            data.SomeMethod();
            Console.WriteLine(data.count);
            
            Console.WriteLine("This is test one.");
            Assert.Equal(1,1);
        }

        [Fact]
        public void Test2()
        {
            data.SomeMethod();
            Console.WriteLine(data.count);
            Console.WriteLine("This is test two.");
            Assert.Equal(1, 1);
        }

        public void Dispose()
        {
            Console.WriteLine(data.count);
            Console.WriteLine("Disposing");
        }

    }
}
