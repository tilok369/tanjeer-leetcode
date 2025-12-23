namespace LeetCode.Strings._125;

public class LengthLastWord
{
    public static void Run()
    {
        Console.WriteLine("58. Length of last word: ");
        Console.WriteLine(LengthOfLastWord("Hello World"));
        Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
        Console.WriteLine(LengthOfLastWord("a"));
    }
    
    public static int LengthOfLastWord(string s) 
    {
        var size = s.Length - 1;
        while (s[size] == ' ')
        {
            size--;
        }

        var len = 0;
        while (size >= 0 && s[size] != ' ')
        {
            len++;
            size--;
        }
        
        return len;
    }
}