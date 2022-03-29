using System;
namespace MarsRover
{
    public class Grid
    {
        public int maxX;
        public int maxY;

        public Grid(string grid)
        {
            // set values for grid x y
            int.TryParse(grid.Split(" ")[0], out maxX);
            int.TryParse(grid.Split(" ")[1], out maxY);
        }
    }
}
