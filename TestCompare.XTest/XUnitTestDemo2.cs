using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCompare.XTest
{
    [Collection("SomeFixture")]
    public class XUnitTestDemo2
    {
        private SomeFixture data;


        public XUnitTestDemo2(SomeFixture data)
        {
            //this data will be same instance in this XUnitTestDemo3 class
            this.data = data;
            Console.WriteLine("This should be run once before every test " + DateTime.Now.Ticks);
        }

        [Fact]
        public void Test1()
        {
            data.SomeMethod();
            data.SomeMethod();
            Console.WriteLine(data.count);
            Assert.Equal(1, 1);
        }
    }
}
