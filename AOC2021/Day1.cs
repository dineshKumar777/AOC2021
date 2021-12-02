namespace AOC2021
{
    public static class Day1
    {
        //static readonly string sampleInput = @"C:\Users\vdinesh\source\repos\AOC2021\AOC2021\Input\Day1_sample.txt";
        //static readonly string puzzleInput = @"C:\Users\vdinesh\source\repos\AOC2021\AOC2021\Input\Day1_puzzle.txt";

        public static int Part1(string inputType)
        {

            List<string> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(1, inputType)).ToList();

            int counter = 0;
            int temp = 0;

            for (int i = 0; i < allLinesText.Count; i++)
            {
                if (i != 0)
                {
                    if (Int32.Parse(allLinesText[i]) > temp)
                    {
                        counter++;
                    }
                    temp = Int32.Parse(allLinesText[i]);
                }
                else
                {
                    temp = Int32.Parse(allLinesText[i]);
                }
            }

            return counter;
        }

        public static int InternetPart1(string inputType)
        {
            var previous = -1;
            var found = 0;
            List<int> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(1, inputType)).Select(int.Parse).ToList();

            foreach (var number in allLinesText)
            {
                if ((previous != -1) && (number > previous))
                    found++;

                previous = number;
            }

            return found;
        }

        public static int Part2(string inputType)
        {
            List<int> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(1, inputType)).Select(int.Parse).ToList();

            int counter = 0;
            int temp = 0;

            for (int i = 0; i < allLinesText.Count; i++)
            {
                if ((i != 0) && (i + 2 < allLinesText.Count))
                {
                    var currentWindowSum = allLinesText[i] + allLinesText[i + 1] + allLinesText[i + 2];
                    if (currentWindowSum > temp)
                    {
                        counter++;
                    }
                    temp = currentWindowSum;
                }
                else if (i == 0)
                {
                    temp = allLinesText[i] + allLinesText[i + 1] + allLinesText[i + 2];
                }
            }

            return counter;
        }


        public static int InternetPart2(string inputType)
        {
            var previous = -1;
            var found = 0;
            List<int> Input = File.ReadAllLines(Utilities.GetInputPathFor(1, inputType)).Select(int.Parse).ToList();
            

            for (int i = 0; i <= Input.Count - 3; i++)
            {
                var sum = Input.Skip(i).Take(3).Sum();
                if (i == 0)
                {
                    previous = sum;
                }
                else if (sum > previous)
                {
                    found++;
                }
                previous = sum;
            }

            return found;
        }
    }
}
