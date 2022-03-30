using System;
namespace MarsRover
{
    public class Rover
    {
        public int x; // x position of rover
        public int y; // y position of rover
        public string direction; // direction rover is facing N E S W

        public Rover(string location)
        {
            int.TryParse(location.Split(" ")[0], out x);
            int.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }
        public void SpinLeft()
        {
            switch (direction)
            {
                // change direction to 90 degrees left of current heading
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void SpinRight()
        {
            switch (direction)
            {
                // change direction to 90 degrees right of current heading
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void MoveForward(Grid plateau)
        {
            var maxX = plateau.maxX;
            var maxY = plateau.maxY;

            // stop rover and report co-ordinates/direction if it is at any edge, otherwise move forward
            switch (direction)
            {
                case "N":
                    if (y == maxY)
                    {
                        Console.WriteLine($"You are at the edge of the grid at co-ordinates {x} {y}, facing N");
                    }
                    else if (y < maxY)
                    {
                        y += 1;
                    }
                    break;
                case "E":
                    if (x == maxX)
                    {
                        Console.WriteLine($"You are at the edge of the grid at co-ordinates {x} {y}, facing E");
                    }
                    else if (x < maxX)
                    {
                        x += 1;
                    }
                    break;
                case "S":
                    if (y == 0)
                    {
                        Console.WriteLine($"You are at the edge of the grid at co-ordinates {x} {y}, facing S");
                    }
                    else if (y > 0)
                    {
                        y -= 1;
                    }
                    break;
                case "W":
                    if (x == 0)
                    {
                        Console.WriteLine($"You are at the edge of the grid at co-ordinates {x} {y}, facing W");
                    }
                    else if (x > 0)
                    {
                        x -= 1;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void ExecuteCommand(Grid plateau, string roverCommand)
        {
            //loop through roverCommand for each letter and execute command: spinLeft, spinRight, or moveForward
            for(int i = 0; i < roverCommand.Length; i++)
            {
                switch(roverCommand[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        MoveForward(plateau);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
