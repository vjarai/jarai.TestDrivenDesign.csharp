using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class SouthDirection : Direction
    {
        public static readonly SouthDirection Instance = new SouthDirection();

        private SouthDirection() : base("S")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X, position.Y - 1);
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