using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines(@"C:\gitProjects\MazeTest\Samples\input.txt");
            
            // reading the maze inputs from the file
            var width = file[0].Split(' ')[0];
            var height = file[0].Split(' ')[1];
            
            var startX = file[1].Split(' ')[0];
            var startY = file[1].Split(' ')[1];
            
            var endX = file[2].Split(' ')[0];
            var endY = file[2].Split(' ')[1];
            
            foreach(string line in file)
            {
                Console.WriteLine(line);
            }
            
            string[,] maze = new string[int.Parse(width), int.Parse(height)];
            int counter = 0;
            // reading the maze from the file.
            for (int x = 3; x < file.Count(); x++)
            {
                var line = file[x].Split(' ').ToArray();
                for (int y = 0; y < line.Count(); y++)
                {
                    maze[counter,y] = line[y];
                }
                counter++;
            }
            



            /*
            // printing the maze
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for(int y = 0; y < maze.GetLength(1); y++)
                {
                    // check for the start point
                    if (x.ToString() == startX && y.ToString() == startY)
                    {
                        Console.Write("S");
                    }

                    // check for the end point
                    else if (x.ToString() == endX && y.ToString() == endY)
                    {
                        Console.Write("E");
                    }

                    // wall
                    else if (maze[x, y] == "1")
                    {
                        Console.Write("#");
                    }
                    // passage
                    else if (maze[x, y] == "0")
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(maze[x, y]);
                    }

                }
                Console.Write("\n");
            }
            */









                    Console.WriteLine("test");
        }
    }
}
