using FluentAssertions;

namespace EchoMaster.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "Hello world";
            string result = "Hello world";

            expected.Should().Be(result);
        }
    }
}