namespace LeetCode.TwoPointers._28;

public class FindFirstOccurrence
{
    public static void Run()
    {
        Console.WriteLine("Find the Index of the First Occurrence in a String: ");
        Console.WriteLine(FindFirstOccurrence.StrStr("sadbutsad", "sad"));
        Console.WriteLine(FindFirstOccurrence.StrStr("leetcode", "leeto"));
        Console.WriteLine(FindFirstOccurrence.StrStr("leetcode", "leetcode"));
        Console.WriteLine(FindFirstOccurrence.StrStr("qweqwesadbutsad", "sad"));
        Console.WriteLine(FindFirstOccurrence.StrStr("aaa", "aaaa"));
        Console.WriteLine(FindFirstOccurrence.StrStr("mississippi", "issip"));
        Console.WriteLine(FindFirstOccurrence.StrStr("mississippi", "issi"));
        Console.WriteLine(FindFirstOccurrence.StrStr("mississippi", "issipi"));
        Console.WriteLine(FindFirstOccurrence.StrStr("mississippi", "pi"));
        Console.WriteLine(FindFirstOccurrence.StrStr("mississippi", "sippia"));
    }

    public static int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
            return -1;
        var j = 0;
        var index = -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[j])
            {
                if (j == 0)
                    index = i;
                if (j == needle.Length - 1)
                    return index;
                j++;
            }
            else
            {
                if (j > 0)
                    i -= j;
                j = 0;
                index = -1;
            }
        }

        return j == needle.Length ? index : -1;
    }
}
