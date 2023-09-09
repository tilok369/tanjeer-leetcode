namespace LeetCode.DFS._200;

public class NumberOfIslands
{
    public static int NumIslands(char[][] grid)
    {
        var row = grid.Length;
        var col = grid[0].Length;

        var count = 0;

        for (var i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    DfsTraverse(grid, i, j, row, col);
                }
            }
        }

        return count;
    }

    private static void DfsTraverse(char[][] grid, int i, int j, int row, int col)
    {
        if(i < 0 || j < 0 || i > (row - 1) || j > (col - 1) || grid[i][j] != '1')
            return;

        if (grid[i][j] == '1')
        { 
            grid[i][j] = '0';
            DfsTraverse(grid, i + 1, j, row, col);
            DfsTraverse(grid, i, j + 1, row, col);
            DfsTraverse(grid, i - 1, j, row, col);
            DfsTraverse(grid, i, j - 1, row, col);
        }
    }
}
