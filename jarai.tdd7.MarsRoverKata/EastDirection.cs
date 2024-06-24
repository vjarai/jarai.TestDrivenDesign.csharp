using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jarai.tdd7.MarsRoverKata
{
    public class EastDirection : Direction
    {
        public static readonly EastDirection Instance = new EastDirection();

        private EastDirection() : base("E")
        {
        }

        public override Position GetNextPosition(Position position)
        {
            return new Position(position.X + 1, position.Y);
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