using System;
using Xunit;
using MarsRover;

namespace MarsRoverTest
{
    public class RoverTests
    {
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinLeft();
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.SpinRight();
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void MoveForward()
        {
            Rover rover = new Rover("1 2 N");
            Grid grid = new Grid("5 5");
            rover.ExecuteCommand(grid, "MMM");
            Assert.Equal(5, rover.y);
            Assert.True(rover.y == grid.maxY);
        }
        [Fact]
        public void ExecuteCommand()
        {
            Rover rover = new Rover("3 3 E");
            Grid grid = new Grid("5 5");
            rover.ExecuteCommand(grid, "MMRMMRMRRM");
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
