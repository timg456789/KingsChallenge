using System;
using KingsChallengeCore;
using NUnit.Framework;

namespace KingsChallengeTests.BoardTests
{
    class OneByOne
    {

        [Test]
        public void Available_Combinations_1x2()
        {
            string expectedPrintout = "|3|3|0|";

            var game = new Game();
            var board = game.GetBoardAfterOneRun(3, 1);

            int a = (int) board[0, 0].State;
            int b = (int) board[0, 1].State;
            int c = (int) board[0, 2].State;

            string actualPrintout = $"|{a}|{b}|{c}|";

            Assert.AreEqual(expectedPrintout, actualPrintout);
        }

    }
}
