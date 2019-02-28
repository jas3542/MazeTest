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

            int[,] item = new int[, ] 
            { 
                { _maze._startX, _maze._startY }
            };

            _visited.Add(item);

            //Check around to see where we can go.
            checkAround();
        }

        // Check around the position for anything.
        private void checkAround()
        {
            // TOP  TODO: checkif there is something there (wall, etc...)
            if (_maze._unsolvedMaze[_maze._startX,(_maze._startY - 1)] != null)
            {

            }
            // RIGHT
            if (_maze._unsolvedMaze[(_maze._startX + 1), _maze._startY] != null)
            {

            }
            // DOWN
            if (_maze._unsolvedMaze[(_maze._startX + 1), _maze._startY] != null)
            {

            }
            // LEFT
            if (_maze._unsolvedMaze[(_maze._startX - 1), _maze._startY] != null)
            {

            }
        }
    }
}
