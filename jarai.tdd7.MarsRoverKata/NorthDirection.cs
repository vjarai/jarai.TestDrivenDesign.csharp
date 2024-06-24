using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class NorthDirection : Direction
    {
        public static NorthDirection Instance { get; } = new NorthDirection();

        private NorthDirection() : base("N")
        {
        }

        public override Position Move(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y + 1);
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