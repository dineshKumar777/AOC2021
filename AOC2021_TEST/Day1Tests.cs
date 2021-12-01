using NUnit.Framework;
using AOC2021;

namespace AOC2021_TEST
{
    public class Day1Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Part1()
        {
            Assert.AreEqual(7, Day1.Part1(1, "sample"));
            Assert.AreEqual(1624, Day1.Part1(1, "puzzle"));
        }

        [Test]
        public void Part2()
        {
            Assert.AreEqual(5, Day1.Part2(1, "sample"));
            Assert.AreEqual(1653, Day1.Part2(1, "puzzle"));
        }
    }
}