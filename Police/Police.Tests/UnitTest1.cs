using System;
using Xunit;

namespace Police.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string test = "howdy";
            Assert.Equal("howdy", test);
        }
    }
}
