namespace LeetCode.Matrix._1337;

public class KWeakestRowsMatrix
{
    public static void Run()
    {
        var mat1 = new int[][] { new[] { 1, 1, 0, 0, 0 }, new[] { 1, 1, 1, 1, 0 }, new[] { 1, 0, 0, 0, 0 }, new[] { 1, 1, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 } };
        var mat2 = new int[][] { new[] { 1, 0, 0, 0 }, new[] { 1, 1, 1, 1 }, new[] { 1, 0, 0, 0 }, new[] { 1, 0, 0, 0 } };

        Console.WriteLine("K Weakest Rows:");
        Console.WriteLine(string.Join(", ", KWeakestRowsMatrix.KWeakestRows(mat1, 3)));
        Console.WriteLine(string.Join(", ", KWeakestRowsMatrix.KWeakestRows(mat2, 2)));
    }

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