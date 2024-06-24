using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class WestDirection : Direction
    {
        public static readonly WestDirection Instance = new WestDirection();

        private WestDirection() : base("W")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X, position.Y - 1);
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