using System;
using Lib;
using Xunit;

namespace LibTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cal = new Cal();
            var actual = cal.Add(1, 2);
            Assert.Equal(3, actual);
        }
    }
}