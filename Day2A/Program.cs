using System;

namespace Day2A
{
    class Program
    {
        static void Main(string[] args)
        {
            int depth = 0;
            int horizontal = 0;

            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            foreach (string line in lines)
            {
                string[] command = line.Split(' ');

                switch (command[0])
                {
                    case "up":
                        depth = depth - Int16.Parse(command[1]);
                        break;

                    case "down":
                        depth = depth + Int16.Parse(command[1]);
                        break;

                    case "forward":
                        horizontal = horizontal + Int16.Parse(command[1]);
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
