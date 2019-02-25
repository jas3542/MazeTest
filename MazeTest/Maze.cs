using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class Maze
    {
        public int _mazeWidth { get; set; }
        public int _mazeHeight { get; set; }

        public int _startX { get; set; }
        public int _startY { get; set; }

        public int _endX { get; set; }
        public int _endY { get; set; }

        public string[,] _unsolvedMaze { get; set; }

        public Maze()
        {

        }
    }
}
