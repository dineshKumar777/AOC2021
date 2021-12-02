namespace AOC2021
{
    public static class Day2
    {


        public static int Part1(string inputType)
        {

            List<string> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(2, inputType)).ToList();
            //var test = allLinesText.Select(item => item.Split(' ')).Select(a => new { dir = a[0], val = Convert.ToInt32(a[1]) }).GroupBy(x => x.dir).Select(group => new { direction = group.Key, depth = group.Sum(f => f.val) });
            //int forward = test.Where(x => x.direction == "forward").Select(x => x.depth).FirstOrDefault();
            int forwardValue = 0;
            int depthValue = 0;

            for (int i = 0; i < allLinesText.Count; i++)
            {
                int pos = Convert.ToInt32(allLinesText[i].Split(' ')[1]);
                if(allLinesText[i].StartsWith("forward"))
                {
                    forwardValue += pos;
                }
                else if (allLinesText[i].StartsWith("down"))
                {
                    depthValue += pos;
                }
                else if (allLinesText[i].StartsWith("up"))
                {
                    depthValue -= pos;
                }
            }

            Console.WriteLine(forwardValue + " => " + depthValue);

            return forwardValue*depthValue;
        }


        public static int Part2(string inputType)
        {
            List<string> allLinesText = File.ReadAllLines(Utilities.GetInputPathFor(2, inputType)).ToList();

            int forwardValue = 0;
            int depthValue = 0;
            int aim = 0;

            for (int i = 0; i < allLinesText.Count; i++)
            {
                int pos = Convert.ToInt32(allLinesText[i].Split(' ')[1]);
                if (allLinesText[i].StartsWith("forward"))
                {
                    forwardValue += pos;
                    depthValue += aim * pos;
                }
                else if (allLinesText[i].StartsWith("down"))
                {
                    //depthValue += pos;
                    aim += pos;
                }
                else if (allLinesText[i].StartsWith("up"))
                {
                    //depthValue -= pos;
                    aim -= pos;
                }
            }

            Console.WriteLine(forwardValue + " => " + depthValue);

            return forwardValue * depthValue;
        }


    }
}
