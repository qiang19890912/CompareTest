using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCompare.XTest
{
    [CollectionDefinition("SomeFixture")]
    public class SomeFixtureCollection:ICollectionFixture<SomeFixture>
    {
    }
}
