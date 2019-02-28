using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeTest
{
    class PathFinder
    {
        public List<int[,]> _visited { get; set; }
        private Maze _maze;

        public void FindPath(Maze mazee)
        {
            _maze = mazee;
            _visited = new List<int[,]>();

            int[,] startPoint = new int[, ] 
            { 
                { _maze._startX, _maze._startY }
            };

            _visited.Add(startPoint);

            //Check around to see where we can go.
            checkAround();
        }

        // Check around the position for anything.
        private void checkAround()
        {
            // TOP  TODO: checkif there is something there (wall, etc...)
            if (_maze._unsolvedMaze[_maze._startX,(_maze._startY - 1)] != null 
                && _maze._unsolvedMaze[_maze._startX, (_maze._startY - 1)] != "1")
            {
                //Console.WriteLine("1- " + _maze._startX + "," + (_maze._startY - 1));
            }
            // RIGHT
            if (_maze._unsolvedMaze[(_maze._startX + 1), _maze._startY] != null
                && _maze._unsolvedMaze[(_maze._startX + 1), _maze._startY] != "1")
            {
                //Console.WriteLine("2- " + (_maze._startX + 1) + "," + _maze._startY);
            }
            // DOWN
            if (_maze._unsolvedMaze[_maze._startX , (_maze._startY + 1)] != null
                && _maze._unsolvedMaze[_maze._startX, (_maze._startY + 1)] != "1")
            {
                //Console.WriteLine("3- " + _maze._startX + "," + (_maze._startY + 1));
            }
            // LEFT
            if (_maze._unsolvedMaze[(_maze._startX - 1), _maze._startY] != null
                && _maze._unsolvedMaze[(_maze._startX - 1), _maze._startY] != "1")
            {
                //Console.WriteLine("4- " + (_maze._startX - 1) + "," + _maze._startY);
            }
        }
    }
}
