using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class NorthDirection : Direction
    {
        public NorthDirection() : base("N")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X, position.Y + 1);
        }

        public override Direction TurnLeft()
        {
            return new WestDirection();
        }

        public override Direction TurnRight()
        {
           return new EastDirection();
        }
    }
}