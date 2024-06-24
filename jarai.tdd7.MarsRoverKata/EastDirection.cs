using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class EastDirection : Direction
    {
        public static EastDirection Instance { get; } = new EastDirection();

        private EastDirection() : base("E")
        {
        }

        public override Position Move(Position currentPosition)
        {
            return new Position(currentPosition.X + 1, currentPosition.Y);
        }

        public override Direction TurnLeft()
        {
            return  NorthDirection.Instance;
        }

        public override Direction TurnRight()
        {
            return  SouthDirection.Instance;
        }
    }
}