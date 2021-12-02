using NUnit.Framework;
using AOC2021;

namespace AOC2021_TEST
{
    public class Day2Tests
    {
        [Test]
        public void Part1()
        {
            Assert.AreEqual(150, Day2.Part1("sample"));
            Assert.AreEqual(1427868, Day2.Part1("puzzle"));
        }

        [Test]
        public void Part2()
        {
            Assert.AreEqual(900, Day2.Part2("sample"));
            Assert.AreEqual(1568138742, Day2.Part2("puzzle"));
        }
    }
}