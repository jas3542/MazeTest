using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class FileUtility
    {
        public void readFile(out Maze maze)
        {
            maze = new Maze();

            var fileText = File.ReadAllLines(@"C:\gitProjects\MazeTest\Samples\input.txt");

            // reading the maze inputs from the file
            maze._mazeWidth = int.Parse(fileText[0].Split(' ')[0]);
            maze._mazeHeight = int.Parse(fileText[0].Split(' ')[1]);

            maze._startX = int.Parse(fileText[1].Split(' ')[0]);
            maze._startY = int.Parse(fileText[1].Split(' ')[1]);

            maze._endX = int.Parse(fileText[2].Split(' ')[0]);
            maze._endY = int.Parse(fileText[2].Split(' ')[1]);
            
            maze._unsolvedMaze = new string[maze._mazeWidth, maze._mazeHeight];

            int counter = 0;
            // reading the maze from the file.
            for (int x = 3; x < fileText.Count(); x++)
            {
                var line = fileText[x].Split(' ').ToArray();
                for (int y = 0; y < line.Count(); y++)
                {
                    maze._unsolvedMaze[counter, y] = line[y];
                }
                counter++;
            }
            
        }
    }
}
