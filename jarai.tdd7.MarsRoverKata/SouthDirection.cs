using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class SouthDirection : Direction
    {
        public SouthDirection() : base("S")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X, position.Y - 1);
        }

        public override Direction TurnLeft()
        {
            return new EastDirection();
        }

        public override Direction TurnRight()
        {
            return new WestDirection();
        }
    }
}