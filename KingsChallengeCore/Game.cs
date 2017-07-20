
using System.Collections.Generic;

namespace KingsChallengeCore
{
    public class Game
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public HashSet<Position> PastMoves { get; set; }
    }
}
