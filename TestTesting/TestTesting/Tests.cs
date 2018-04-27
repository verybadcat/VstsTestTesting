using System;
using Xunit;

namespace TestTesting
{
    public class Tests
    {
        [Fact]
        public void Passing()
        {
            Assert.True(true);
        }
        [Fact]
        public void Failing()
        {
            Assert.True(false);
        }
        [Fact(Skip ="Skipping")]
        public void Skipped()
        {
            Assert.True(false);
        }
    }
}
