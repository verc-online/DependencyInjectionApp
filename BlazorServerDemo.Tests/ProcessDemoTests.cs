using BlazorServerDemo.Data;

namespace BlazorServerDemo.Tests
{
    public class ProcessDemoTests
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("1/2/2000"));
            ProcessDemo p = new(t);

            int expected = 29;

            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDaysInMonth_ShouldReturnProperForNonLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("1/2/2001"));
            ProcessDemo p = new(t);

            int expected = 28;

            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
    }

    public class TestingDemo : IDemo
    {
        public DateTime StartUpTime { get; init; }

        public TestingDemo(DateTime startTime)
        {
            StartUpTime = startTime;
        }
    }
}