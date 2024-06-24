using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class EastDirection : Direction
    {
        public EastDirection() : base("E")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X + 1, position.Y);
        }

        public override Direction TurnLeft()
        {
            return new NorthDirection();
        }

        public override Direction TurnRight()
        {
            return new SouthDirection();
        }
    }
}