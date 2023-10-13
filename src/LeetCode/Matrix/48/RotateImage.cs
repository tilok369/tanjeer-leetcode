namespace LeetCode.Matrix._48;

public class RotateImage
{
    public static void Run()
    {
        var mat = new int[][] {
            new[] { 1, 2, 3 },
            new[] { 4, 5, 6 },
            new[] { 7, 8, 9 }
        };
        Console.WriteLine("48. Rotate Image: ");
        RotateImage.Rotate(mat);
        Console.WriteLine(string.Join("|", mat.Select(c => string.Join(",", c))));

        var mat2 = new int[][] {
            new[] { 5, 1, 9, 11 },
            new[] { 2, 4, 8, 10 },
            new[] { 13, 3, 6, 7 },
            new[] { 15, 14, 12, 16 }
        };
        Console.WriteLine("Rotate Image: ");
        RotateImage.Rotate(mat2);
        Console.WriteLine(string.Join("|", mat2.Select(c => string.Join(",", c))));

        var mat3 = new int[][] {
            new[] { 5, 1 },
            new[] { 2, 4 }
        };
        Console.WriteLine("Rotate Image: ");
        RotateImage.Rotate(mat3);
        Console.WriteLine(string.Join("|", mat3.Select(c => string.Join(",", c))));

        var mat4 = new int[][] {
            new[] { 5}
        };
        Console.WriteLine("Rotate Image: ");
        RotateImage.Rotate(mat3);
        Console.WriteLine(string.Join("|", mat4.Select(c => string.Join(",", c))));
    }

    public static void Rotate(int[][] matrix)
    {
        var len = matrix.Length;

        for (int i = 0; i < (len / 2) + 1; i++)
        {
            for (int j = i; j < len - i - 1; j++)
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
