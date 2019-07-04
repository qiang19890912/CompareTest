using System;
using System.Linq;
using Xunit;

namespace TestCompare.XTest
{
    public class UnitTest1
    {
        private string name { get; set; }
        /// <summary>
        /// 相当于Nunit的Setup
        /// </summary>
        public UnitTest1()
        {
            this.name = "qiang";

        }

        [Fact]
        public void TestMethod1()
        {
            this.name += 1;
            Console.WriteLine(name);
            Assert.Equal(1,1);
        }

        [Fact]
        public void TestMethod2()
        {
            this.name += 2;
            Console.WriteLine(name);
            Assert.Equal(1, 1);
        }
    }
}
