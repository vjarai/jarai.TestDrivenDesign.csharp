using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class SouthDirection : Direction
    {
        public static SouthDirection Instance { get; } = new SouthDirection();

        private SouthDirection() : base("S")
        {
        }

        public override Position Move(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y - 1);
        }

        public override Direction TurnLeft()
        {
            return EastDirection.Instance;
        }

        public override Direction TurnRight()
        {
            return WestDirection.Instance;
        }
    }
}