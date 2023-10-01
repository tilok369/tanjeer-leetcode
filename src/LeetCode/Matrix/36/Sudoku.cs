namespace LeetCode.Matrix._36;

public class Sudoku
{
    public static void Run()
    {
        Console.WriteLine("36. Valid Sudoku: ");

        var board1 = new char[][]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

        var board2 = new char[][]
            {
                new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

        var board3 = new char[][]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] { '.', '.', '.', '4', '7', '9', '.', '.', '5'},
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

        var board4 = new char[][]
            {
                new[] { '1', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

        var board5 = new char[][]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] { '.', '.', '.', '4', '7', '9', '.', '.', '5'},
                new[] { '9', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

        Console.WriteLine(Sudoku.IsValidSudoku(board1));
        Console.WriteLine(Sudoku.IsValidSudoku(board2));
        Console.WriteLine(Sudoku.IsValidSudoku(board3));
        Console.WriteLine(Sudoku.IsValidSudoku(board4));
        Console.WriteLine(Sudoku.IsValidSudoku(board5));
    }

    public static bool IsValidSudoku(char[][] board)
    {
        if (board.Length != 9 || board[0].Length != 9)
            return false;

        var subBoxes = new Dictionary<string, Dictionary<char, char>>();
        for (int i = 0; i < 9; i++)
        {
            var rowDigits = new Dictionary<char, char>();
            var colDigits = new Dictionary<char, char>();

            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    if (((int)board[i][j] - 48) < 1 || ((int)board[i][j] - 48) > 9)
                        return false;
                    if (rowDigits.ContainsKey(board[i][j]))
                        return false;
                    rowDigits.Add(board[i][j], board[i][j]);

                    if (!subBoxes.ContainsKey((i / 3) + "" + (j / 3) + ""))
                        subBoxes.Add((i / 3) + "" + (j / 3) + "", new Dictionary<char, char>());
                    if (subBoxes[(i / 3) + "" + (j / 3) + ""].ContainsKey(board[i][j]))
                        return false;
                    subBoxes[(i / 3) + "" + (j / 3) + ""].Add(board[i][j], board[i][j]);
                }
                if (board[j][i] != '.')
                {
                    if (((int)board[j][i] - 48) < 1 || ((int)board[j][i] - 48) > 9)
                        return false;
                    if (colDigits.ContainsKey(board[j][i]))
                        return false;
                    colDigits.Add(board[j][i], board[j][i]);
                }
            }
        }

        return true;
    }
}
