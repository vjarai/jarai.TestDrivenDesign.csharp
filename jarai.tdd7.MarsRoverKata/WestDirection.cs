using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class WestDirection : Direction
    {
        public static WestDirection Instance { get; } = new WestDirection();

        private WestDirection() : base("W")
        {
        }

        public override Position Move(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y - 1);
        }

        public override Direction TurnLeft()
        {
            return SouthDirection.Instance;
        }

        public override Direction TurnRight()
        {
            return NorthDirection.Instance;
        }
    }
}