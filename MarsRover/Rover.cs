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
            switch (direction)
            {
                case "N":
                    if (y == maxY)
                    {
                        Console.WriteLine("You are at the edge of the grid at the top");
                    }
                    else if (y < maxY)
                    {
                        y += 1;
                    }
                    break;
                case "E":
                    if (x == maxX)
                    {
                        Console.WriteLine("You are at the edge of the grid on the right side");
                    }
                    else if (x < maxX)
                    {
                        x += 1;
                    }
                    break;
                case "S":
                    if (y == 0)
                    {
                        Console.WriteLine("You are at the edge of the grid at the bottom");
                    }
                    else if (y > 0)
                    {
                        y -= 1;
                    }
                    break;
                case "W":
                    if (x == 0)
                    {
                        Console.WriteLine("You are at the edge of the grid on the left side");
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
            char[] instructions = roverCommand.ToCharArray();
            //loop through array for each letter => spinLeft, spinRight, or moveForward
            for(int i = 0; i < instructions.Length; i++)
            {
                switch(instructions[i])
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
