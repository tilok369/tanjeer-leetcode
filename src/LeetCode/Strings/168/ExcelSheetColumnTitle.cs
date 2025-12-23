using System.Text;

namespace LeetCode.Strings._168;

public class ExcelSheetColumnTitle
{
    public static void Run()
    {
        Console.WriteLine("168. Excel Sheet To Column Title: ");
        Console.WriteLine(ConvertToTitle(1));
        Console.WriteLine(ConvertToTitle(28));
        Console.WriteLine(ConvertToTitle(701));
        Console.WriteLine(ConvertToTitle(702));
        Console.WriteLine(ConvertToTitle(703));
    }
    
    private static string ConvertToTitle(int columnNumber)
    {
        var result = new StringBuilder();

        while (columnNumber > 0)
        {
            columnNumber--; // make it 0-based
            int remainder = columnNumber % 26;
            char letter = (char)('A' + remainder);
            result.Insert(0, letter);
            columnNumber /= 26;
        }

        return result.ToString();
    }
}