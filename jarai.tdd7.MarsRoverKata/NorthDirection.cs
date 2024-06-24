using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class NorthDirection : Direction
    {
        public static readonly NorthDirection Instance = new NorthDirection();

        private NorthDirection() : base("N")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X, position.Y + 1);
        }

        public override Direction TurnLeft()
        {
            return WestDirection.Instance;
        }

        public override Direction TurnRight()
        {
            return EastDirection.Instance;
        }
    }
}