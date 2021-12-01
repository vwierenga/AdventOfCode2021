using System;
using System.Collections.Generic;

namespace Day1B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            int increases = 0;

            List<int> window = new List<int>();

            System.Console.WriteLine("Scanning depth using a sliding window...");
            foreach (string line in lines)
            {
                int number = Int16.Parse(line);

                window.Add(number);

                if (window.Count >= 4)
                {
                    int prefWindow = window[0] + window[1] + window[2];
                    int thisWindow = window[1] + window[2] + window[3];

                    if (prefWindow < thisWindow)
                        increases++;

                    window.RemoveAt(0);
                }
            }
            System.Console.WriteLine("Number of sliding window increases: " + increases);
        }
    }
}
