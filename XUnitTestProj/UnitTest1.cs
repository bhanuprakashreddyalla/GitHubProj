using System;
using Xunit;

namespace XUnitTestProj
{
    public class UnitTest1
    {
        [Fact]
        public void TestPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestFail()
        {
            Assert.True(false);
        }
    }
}
