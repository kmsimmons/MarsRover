using System;
using System.Linq;
// To do:
// Add coordinates on edge alert (you are at the edge at: x, y)
// Account for multiple rovers
// Bonus:
// Ensure subsequent robots don't run into robots who have finished commands
//      if one robot ends at 1 3 N, make sure no other robots go over 1 3

// 5 5 take these two numbers to make the grid
// 1 2 N set of coordinates and direction
// LMLMLMLMM command
// 3 3 E
// MMRMMRMRRM


namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            var maxGrid = Console.ReadLine();
            var startPositions = Console.ReadLine().ToUpper();
            var moves = Console.ReadLine().ToUpper();
            // create new grid
            var plateau = new Grid(maxGrid);
            // create new rover with position
            var rover = new Rover(startPositions);
            rover.ExecuteCommand(plateau, moves);
            Console.WriteLine($"{rover.x} {rover.y} {rover.direction}");
        }
    }
}
