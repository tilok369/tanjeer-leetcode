namespace LeetCode.Recursion._1763;

public class LongestNiceSubstring
{
    public static void Run()
    {
        Console.WriteLine("1763.Longest Nice Substring: ");
        Console.WriteLine(LongestNiceSubstring.LongestNiceSubstrings("YazaAay"));
        Console.WriteLine(LongestNiceSubstring.LongestNiceSubstrings("abABB"));
        Console.WriteLine(LongestNiceSubstring.LongestNiceSubstrings("Bb"));
        Console.WriteLine(LongestNiceSubstring.LongestNiceSubstrings("c"));
    }

    public static string LongestNiceSubstrings(string s)
    {
        return DivideNConq(s);
    }

    private static string DivideNConq(string s)
    {
        var set = new HashSet<char>(s);
        if (s.Length < 2)
            return string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (!set.Contains(char.ToLower(s[i])) || !set.Contains(char.ToUpper(s[i])))
            {
                var s1 = DivideNConq(s.Substring(0, i));
                var s2 = DivideNConq(s.Substring(i + 1, s.Length - i - 1));

                return s1.Length >= s2.Length ? s1 : s2;
            }
        }

        return s;
    }
}
