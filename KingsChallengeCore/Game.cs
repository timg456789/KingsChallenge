using System;

namespace KingsChallengeCore
{
    public class Game
    {
        public Square[,] GetBoardAfterOneRun(int columns, int rows)
        {
            var board = new Square[rows, columns];
            
            for (var col = 0; col < columns; col++)
            {
                for (var row = 0; row < rows; row++)
                {
                    var square = new Square();

                    if (board.GetUpperBound(1) > col) // Has space right
                    {
                        square.State = SquareState.East;
                    }
                    else if (board.GetUpperBound(0) > row)
                    {
                        square.State = SquareState.South;
                    }

                    board[row, col] = square;
                }
            }

            return board;
        }
    }
}
