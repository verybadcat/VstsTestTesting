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
        public void NoLongerFailing()
        {
            Assert.False(false);
        }
        [Fact(Skip ="Skipping")]
        public void Skipped()
        {
            Assert.True(false);
        }
    }
}
