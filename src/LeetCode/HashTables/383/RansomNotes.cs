namespace LeetCode.HashTables._383;

public class RansomNotes
{
    public static void Run()
    {
        Console.WriteLine("383. Ransom Notes:");
        Console.WriteLine(RansomNotes.CanConstruct("a", "b"));
        Console.WriteLine(RansomNotes.CanConstruct("aa", "ab"));
        Console.WriteLine(RansomNotes.CanConstruct("aa", "aab"));
        Console.WriteLine(RansomNotes.CanConstruct("aabbc", "ababcc"));
        Console.WriteLine(RansomNotes.CanConstruct("aassswe", "aabssew"));
    }

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineDic = new Dictionary<char, int>();
        foreach (var c in magazine)
        {
            if (!magazineDic.ContainsKey(c))
                magazineDic.Add(c, 1);
            else
                magazineDic[c]++;

        }
        foreach (var c in ransomNote)
        {
            if (!magazineDic.ContainsKey(c))
                return false;
            if (magazineDic.ContainsKey(c) && magazineDic[c] <= 0)
                return false;
            magazineDic[c]--;
        }

        return true;
    }
}
