// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestCompare.Test
{
    [TestFixture]
    public class TestClass
    {
        public string name { get; set; }

        public string school { get; set; }

        public TestContext TestContext { get; set; }

        //[TestFixtureSetUp]和Setup一个作用，同理TearDown和TestFixtureTearDown一样
        public void Init()
        {

        }


        /// <summary>
        /// call before each test method
        /// </summary>
        [SetUp]
        public void SetUpTest()
        {
           
            this.name = "alan";
        }

        [Test]
        public void TestMethod()
        {
            name += 1;
            Console.WriteLine(name);

            Assert.AreEqual(1, 1);
          
        }

        [Test]
        
        public void TestMethod1()
        {
            name += 2;
            Console.WriteLine(name);

            Assert.AreEqual(1, 1);
        }

        [TearDown]
        public void TearDownTest()
        {
            Console.WriteLine(name);
        }
    }
}