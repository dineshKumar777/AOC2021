using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2021
{
    public class Utilities
    {
        public static string GetInputPathFor(int day, string inputType)
        {
            var datasetFolderPath = @"C:\Users\vdinesh\source\repos\AOC2021\AOC2021\Input\";

            return datasetFolderPath + $"Day{day}_{inputType.ToLower()}.txt";
        }
    }
}
