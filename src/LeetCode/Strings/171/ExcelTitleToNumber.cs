namespace LeetCode.Strings._171;

public class ExcelTitleToNumber
{
    public static void Run()
    {
        Console.WriteLine("171. Excel Sheet Title To Column Number: ");
        Console.WriteLine(TitleToNumber("A"));
        Console.WriteLine(TitleToNumber("AB"));
        Console.WriteLine(TitleToNumber("ZY"));
    }
    
    private static int TitleToNumber(string columnTitle) 
    {
        int result = 0;

        foreach (char c in columnTitle)
        {
            int value = c - 'A' + 1;
            result = result * 26 + value;
        }

        return result;
    }
}