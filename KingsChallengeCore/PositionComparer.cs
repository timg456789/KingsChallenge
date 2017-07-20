using System.Collections.Generic;

namespace KingsChallengeCore
{
    class PositionComparer : IEqualityComparer<Position>
    {
        public bool Equals(Position positionA, Position positionB)
        {
            return positionA.X == positionB.X &&
                   positionA.Y == positionB.Y;
        }

        public int GetHashCode(Position obj)
        {
            return $"{{x: {obj.X}, y: {obj.Y}}}".GetHashCode();
        }
    }
}
