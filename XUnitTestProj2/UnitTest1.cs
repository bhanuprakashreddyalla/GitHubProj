using System;
using Xunit;

namespace XUnitTestProj2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(false);
        }
    }
}