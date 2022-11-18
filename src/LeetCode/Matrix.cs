
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

    public static void Rotate(int[][] matrix)
    {
        var len = matrix.Length;

        for (int i = 0; i < (len / 2) + 1; i++)
        {
            for (int j = i; j < len - i  - 1; j++)
            {
                var i1 = i;
                var j1 = j;
                var i2 = j1;
                var j2 = len - 1 - i1;
                var i3 = j2;
                var j3 = len - 1 - i2;
                var i4 = j3;
                var j4 = len - 1 - i3;
                var temp = matrix[i1][j1];
                matrix[i1][j1] = matrix[i4][j4];
                matrix[i4][j4] = matrix[i3][j3];
                matrix[i3][j3] = matrix[i2][j2];
                matrix[i2][j2] = temp;
            }
        }
    }
}
