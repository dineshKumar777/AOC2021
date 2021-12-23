using NUnit.Framework;
using AOC2021;

namespace AOC2021_TEST
{
    public class Day3Tests
    {
        [Test]
        public void Part1()
        {
            Assert.AreEqual(198, Day3.Part1("sample"));
            Assert.AreEqual(3148794, Day3.Part1("puzzle"));
        }

        [Test]
        public void Part2()
        {
            Assert.AreEqual(230, Day3.Part2("sample"));
            Assert.AreEqual(2795310, Day3.Part2("puzzle"));
        }

    }
}