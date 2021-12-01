using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            int lastNumber = 0;
            int increases = -1; //hacks

            System.Console.WriteLine("Scanning depth...");
            foreach (string line in lines)
            {
                int number = Int16.Parse(line);

                if (number > lastNumber)
                {
                    increases++;
                    //System.Console.WriteLine("Depth increased from " + lastNumber + " to " + number);
                }
                    

                lastNumber = number;
            }

            System.Console.WriteLine("Number of depth increases: " + increases);
        }
    }
}
