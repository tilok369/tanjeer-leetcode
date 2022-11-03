
namespace LeetCode;

public class Sudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        if(board.Length != 9 || board[0].Length != 9)
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
                    if (((int)board[i][j]-48) < 1 || ((int)board[i][j]-48) > 9)
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
                    if (((int)board[j][i]-48) < 1 || ((int)board[j][i]-48) > 9)
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
