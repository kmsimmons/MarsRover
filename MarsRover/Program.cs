using System;
using System.Linq;

// Bonus:
// Ensure subsequent robots don't run into robots who have finished commands,
// if one robot ends at 1 3 N, make sure no other robots go over 1 3

// Tracking: keep track of covered points to know which points are undiscovered
// after all rovers complete commands, could be useful if in the future there were
// a requirement to view the entire plateau


namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create new grid
            var maxGrid = Console.ReadLine();
            var plateau = new Grid(maxGrid);

            for (int i = 0; i < args.Length; i++)
            {
                // store values for starting position and command
                var startPositions = Console.ReadLine().ToUpper();
                var moves = Console.ReadLine().ToUpper();

                // create new rover with position
                var rover = new Rover(startPositions);

                // send the commands to the rover
                rover.ExecuteCommand(plateau, moves);

                // record output
                Console.WriteLine($"{rover.x} {rover.y} {rover.direction}");
            }
        }
    }
}