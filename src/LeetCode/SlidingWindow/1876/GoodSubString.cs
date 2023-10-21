namespace LeetCode.SlidingWindow._1876;

public class GoodSubString
{
    public static void Run()
    {
        Console.WriteLine("1876. Substrings of Size Three with Distinct Characters: ");
        Console.WriteLine(GoodSubString.CountGoodSubstrings("xyzzaz"));
        Console.WriteLine(GoodSubString.CountGoodSubstrings("aababcabc"));
    }

    public static int CountGoodSubstrings(string s)
    {
        var hashTable = new Dictionary<char, int>();
        var start = 0;
        var index = 0;
        var good = 0;
        for (int end = 0; end < s.Length; end++)
        {
            if (hashTable.ContainsKey(s[end]))
                hashTable[s[end]]++;
            else
                hashTable.Add(s[end], 1);
            index++;

            if (index == 3)
            {
                if (!hashTable.Any(i => i.Value > 1))
                    good++;
                if (hashTable.ContainsKey(s[start]))
                    hashTable[s[start]]--;
                start++;
                index--;
            }
        }

        return good;
    }
}
