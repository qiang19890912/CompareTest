using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCompare.XTest
{
    /// <summary>
    /// Collection mean that fixture instance is shared in different test class
    /// </summary>
    [Collection("SomeFixture")]
    public class XUnitTestDemo3
    {
        private SomeFixture data;


        public XUnitTestDemo3(SomeFixture data)
        {
            //this data will be same instance in this XUnitTestDemo3 class
            this.data = data;
            Console.WriteLine("This should be run once before every test " + DateTime.Now.Ticks);
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test1()
        {
            data.SomeMethod();
            Console.WriteLine(data.count);
        }
    }
}
