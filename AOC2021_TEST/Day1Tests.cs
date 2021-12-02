using NUnit.Framework;
using AOC2021;

namespace AOC2021_TEST
{
    public class Day1Tests
    {
        [Test]
        public void Part1()
        {
            Assert.AreEqual(7, Day1.Part1("sample"));
            Assert.AreEqual(1624, Day1.Part1("puzzle"));
        }

        [Test]
        public void Part2()
        {
            Assert.AreEqual(5, Day1.Part2("sample"));
            Assert.AreEqual(1653, Day1.Part2("puzzle"));
        }
    }
}