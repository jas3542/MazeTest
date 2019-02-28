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
            Maze maze;
            FileUtility fileUtility = new FileUtility();

            fileUtility.readFile(out maze);
            
            


            // printing the maze
            for (int x = 0; x < maze._unsolvedMaze.GetLength(0); x++)
            {
                for(int y = 0; y < maze._unsolvedMaze.GetLength(1); y++)
                {
                    // check for the start point
                    if (x == maze._startX && y == maze._startY)
                    {
                        Console.Write("S");
                    }

                    // check for the end point
                    else if (x == maze._endX && y == maze._endY)
                    {
                        Console.Write("E");
                    }

                    // wall
                    else if (maze._unsolvedMaze[x, y] == "1")
                    {
                        Console.Write("#");
                    }
                    // passage
                    else if (maze._unsolvedMaze[x, y] == "0")
                    {
                       Console.Write(" ");
                        // TODO Find the path to End

                        PathFinder pathFinder = new PathFinder();
                        pathFinder.FindPath(maze);




                    }
                    else
                    {
                        Console.Write(maze._unsolvedMaze[x, y]);
                        
                    }

                }
                Console.Write("\n");
            }
            
    
            
            Console.ReadLine();
        }

        
    }
    
}

