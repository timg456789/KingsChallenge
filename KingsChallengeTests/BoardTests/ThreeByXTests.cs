using System;
using System.Linq;
using KingsChallengeCore;
using NUnit.Framework;

namespace KingsChallengeTests.BoardTests
{
    class ThreeByXTests
    {
        public const int MAX_X = 2;
        public const int MAX_Y = 2;

        [Test]
        public void TopLeftCornerNoNeighbors_Can_Move_East()
        {
            GameFactory gameFactory = new GameFactory();
            Game game = gameFactory.Create(MAX_X, MAX_Y);
            Console.WriteLine($"starting position {game.PastMoves.Last().X}/{game.PastMoves.Last().Y}");
            Assert.IsTrue(CanMoveEast(game));
            Tick(game);
            var lastMove = game.PastMoves.Last();
            Console.WriteLine($"Next position {lastMove.X}/{lastMove.Y}");
            Assert.AreEqual(1, lastMove.X);
            Assert.AreEqual(0, lastMove.Y);
        }

        public void Tick(Game game)
        {
            var currentPosition = game.PastMoves.Last();
            var x = currentPosition.X;
            var y = currentPosition.Y;

            if (CanMoveEast(game))
            {
                x += 1;
            }

            var nextPosition = new Position(x, y);
            game.PastMoves.Add(nextPosition);
        }

        public bool CanMoveEast(Game game)
        {
            var currentPosition = game.PastMoves.Last();
            var x = currentPosition.X;
            var y = currentPosition.Y;
            return x + 1 < game.MaxX;

            /*
            var east = new Position(x + 1, y);
            if (game.PastMoves.Contains())
            {
                
            }
            //game.pastmoves*/
        }


        /*
        

        */
            /*
            public void TickUntilNoMoreMoves(Game game)
            {
                
            }
            */

            /*
             * This test is pretty complex. I need all of the rules before I can run it.
            [Test]
            public void Successful_Run()
            {
                int maxX = 2;
                int maxY = 2;
                GameFactory gameFactory = new GameFactory();
                Game game = gameFactory.Create(maxX, maxY);
                Assert.AreEqual(0, game.PastMoves[0].X);
                Assert.AreEqual(0, game.PastMoves[0].Y);
                Tick(game);
                Assert.AreEqual(0, game.PastMoves[1].X);
                Assert.AreEqual(1, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(1, game.PastMoves[1].X);
                Assert.AreEqual(2, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(0, game.PastMoves[1].X);
                Assert.AreEqual(2, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(1, game.PastMoves[1].X);
                Assert.AreEqual(1, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(2, game.PastMoves[1].X);
                Assert.AreEqual(2, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(2, game.PastMoves[1].X);
                Assert.AreEqual(1, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(1, game.PastMoves[1].X);
                Assert.AreEqual(0, game.PastMoves[1].Y);
                Tick(game);
                Assert.AreEqual(2, game.PastMoves[1].X);
                Assert.AreEqual(0, game.PastMoves[1].Y);
            }
            */
        }
}
