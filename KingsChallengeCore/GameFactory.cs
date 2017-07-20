
using System.Collections.Generic;

namespace KingsChallengeCore
{
    public class GameFactory
    {
        public Game Create(int maxX, int maxY)
        {
            var game = new Game();
            game.MaxX = maxX;
            game.MaxY = maxY;
            game.PastMoves = new HashSet<Position>(new PositionComparer());
            game.PastMoves.Add(new Position(0, 0));
            return game;
        }
    }
}
