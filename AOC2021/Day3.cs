using System.Linq;

namespace AOC2021
{
    public static class Day3
    {


        public static int Part1(string inputType)
        {

            List<string> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(3, inputType)).ToList();
            

            var inputChars = allLinesText.Select(i => i.ToCharArray());
            var gammarate = "";
            var epsilon = "";

            for (int i = 0; i < allLinesText[0].Length; i++)
            {
                var grouping = (inputChars.Select(x => x[i]).GroupBy(item => item).Select(itemGroup => new { Item = itemGroup.Key, Count = itemGroup.Count() }).OrderByDescending(item => item.Count).ThenBy(item => item.Item)).ToList();
                gammarate += grouping.First().Item.ToString();
                epsilon += grouping.Last().Item.ToString();
            }

            var d_gammarate = Convert.ToInt32(gammarate, 2);
            var d_epsilonrate = Convert.ToInt32(epsilon, 2);

            Console.WriteLine(gammarate + " => " + epsilon);

            return d_gammarate * d_epsilonrate;
        }


        public static int Part2(string inputType)
        {
            List<string> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(3, inputType)).ToList();


            var testing = allLinesText
                   .Select(i => i.ToCharArray())
                   .Select(x => x[0])
                   .GroupBy(item => item)
                   .Select(itemGroup => new
                   {
                       Item = itemGroup.Key,
                       Count = itemGroup.Count()
                   })
                   .OrderByDescending(item => item.Count)
                   .ThenBy(item => item.Item).ToList();

            var mostCommon = testing.First().Item.ToString();
            var leastCommon = testing.Last().Item.ToString();

            var o2GeneratorRatingList = allLinesText.Where(i => i.StartsWith(mostCommon)).ToList();
            var co2ScrubberRatingList = allLinesText.Where(i => i.StartsWith(leastCommon)).ToList();


            for (int i = 1; i < allLinesText[0].Length; i++)
            {
                var _ = o2GeneratorRatingList
                            .Select(i => i.ToCharArray())
                            .Select(x => x[i])
                            .GroupBy(item => item)
                            .Select(itemGroup => new
                            {
                                Item = itemGroup.Key,
                                Count = itemGroup.Count()
                            })
                            .OrderByDescending(item => item.Count)
                            .ThenBy(item => item.Item).ToList();

                var first = _.First().Item;
                var last = _.Last().Item;


                if (_.First().Count == _.Last().Count)
                {
                    first = '1';
                    mostCommon += first;
                }
                else
                {
                    mostCommon += first;
                }

                //leastCommon += _.Last().Item.ToString();


                o2GeneratorRatingList.RemoveAll(x => x[i] != first);

            }


            for (int i = 1; i < allLinesText[0].Length; i++)
            {
                var _ = co2ScrubberRatingList
                            .Select(i => i.ToCharArray())
                            .Select(x => x[i])
                            .GroupBy(item => item)
                            .Select(itemGroup => new
                            {
                                Item = itemGroup.Key,
                                Count = itemGroup.Count()
                            })
                            .OrderByDescending(item => item.Count)
                            .ThenBy(item => item.Item).ToList();

                var first = _.First().Item;
                var last = _.Last().Item;


                if (_.First().Count == _.Last().Count)
                {
                    last = '0';
                    leastCommon += last;
                }
                else
                {
                    leastCommon += last;
                }

                //leastCommon += _.Last().Item.ToString();


                co2ScrubberRatingList.RemoveAll(x => x[i] != last);

                if (co2ScrubberRatingList.Count == 1)
                {
                    leastCommon += co2ScrubberRatingList[0].Substring(i + 1);
                    break;
                }

            }

            Console.WriteLine(mostCommon);
            Console.WriteLine(leastCommon);

            var o2rating = Convert.ToInt32(mostCommon, 2);
            var co2rating = Convert.ToInt32(leastCommon, 2);

            Console.WriteLine(o2rating + " * " + co2rating + " => " + (o2rating * co2rating));

            return o2rating * co2rating;
        }

    }
}
