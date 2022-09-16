
namespace LeetCode;

public class Matrix
{
    public static int[] KWeakestRows(int[][] mat, int k)
    {
        var r = mat.Length;
        var c = mat[0].Length;
        var index = 0;
        var visited = new int[r];
        var weakestRows = new int[k];

        for (int j = 0; j <= c; j++)
        {
            for (int i = 0; i < r; i++)
            {
                if (visited[i] == 0 && (j == c || mat[i][j] == 0))
                {
                    weakestRows[index++] = i;
                    visited[i] = 1;
                }

                if (index == k)
                    return weakestRows;
            }
        }

        return weakestRows;
    }
}
