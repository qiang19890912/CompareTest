using System;
using System.Linq;
using Xunit;

namespace TestCompare.XTest
{
    public class XUnitDemo:IDisposable
    {
        private string name { get; set; }
        /// <summary>
        /// 相当于Nunit的Setup
        /// </summary>
        public XUnitDemo()
        {
            Console.WriteLine("this sentence will be called twice");

        }

        [Fact]
        public void TestMethod1()
        {
            
            Assert.Equal(1,1);
        }

        [Fact]
        public void TestMethod2()
        {
            
            Assert.Equal(1, 1);
        }

        //[Fact] Fact特性不允许使用inlineData
        [Theory]
        //有几个value就运行几次测试
        [InlineData(1)]
        //[InlineData(2)]
        [InlineData(3)]
        public void TestOdd(int value)
        {
            Assert.True(IsOdd(value));
        }

        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        public void Dispose()
        {
            Console.WriteLine("This method will be called after each test and used for clean up codes");
        }
    }
}
