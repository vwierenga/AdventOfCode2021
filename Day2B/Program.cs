using System;

namespace Day2B
{
    class Program
    {
        static void Main(string[] args)
        {
            int aim = 0;
            int depth = 0;
            int horizontal = 0;

            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            foreach (string line in lines)
            {
                string[] command = line.Split(' ');

                switch (command[0])
                {
                    case "up":
                        aim = aim - Int16.Parse(command[1]);
                        break;

                    case "down":
                        aim = aim + Int16.Parse(command[1]);
                        break;

                    case "forward":
                        int x = Int16.Parse(command[1]);
                        horizontal = horizontal + x;
                        depth = depth + aim * x;
                        break;

                    default:
                        System.Console.WriteLine("Unexpected command received!");
                        break;
                }
            }

            System.Console.WriteLine("Output: " + horizontal * depth);
        }
    }
}
