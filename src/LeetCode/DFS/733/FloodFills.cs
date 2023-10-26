namespace LeetCode.DFS._733;

public class FloodFills
{
    public static void Run()
    {
        Console.WriteLine("733. Flood Fill: ");
        var image1 = new int[][]{
            new []{1, 1, 1 },
            new []{ 1, 1, 0},
            new []{ 1, 0, 1}
          };
        Console.WriteLine(string.Join("\n", FloodFills.FloodFill(image1, 1, 1, 2).Select(i => string.Join(", ", i))));

        Console.WriteLine("733. Flood Fill: ");
        var image2 = new int[][]{
            new []{0, 0, 0 },
            new []{ 0, 0, 0}
          };
        Console.WriteLine(string.Join("\n", FloodFills.FloodFill(image2, 0, 0, 0).Select(i => string.Join(", ", i))));
    }

    public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var currentColor = image[sr][sc];
        if (currentColor == color)
            return image;

        var row = image.Length;
        var col = image[0].Length;

        //image[sr][sc] = color;
        DfsTraverse(image, sr, sc, row, col, currentColor, color);

        return image;
    }

    private static void DfsTraverse(int[][] image, int i, int j, int row, int col, int currentColor, int color)
    {
        if (i < 0 || j < 0 || i > (row - 1) || j > (col - 1) || image[i][j] != currentColor)
            return;

        if (image[i][j] == currentColor)
        {
            image[i][j] = color;
            DfsTraverse(image, i + 1, j, row, col, currentColor, color);
            DfsTraverse(image, i, j + 1, row, col, currentColor, color);
            DfsTraverse(image, i - 1, j, row, col, currentColor, color);
            DfsTraverse(image, i, j - 1, row, col, currentColor, color);
        }
    }
}
