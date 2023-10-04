namespace LeetCode.HashTables._49;

public class Anagrams
{
    public static void Run()
    {
        Console.WriteLine("49. Group Anagrams: ");
        Console.WriteLine(string.Join("|", Anagrams.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }).Select(x => string.Join(",", x))));
        Console.WriteLine(string.Join("|", Anagrams.GroupAnagrams(new string[] { "" }).Select(x => string.Join(",", x))));
        Console.WriteLine(string.Join("|", Anagrams.GroupAnagrams(new string[] { "a" }).Select(x => string.Join(",", x))));
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, IList<string>>();
        foreach (string str in strs)
        {
            var sorted = string.Join("", str.OrderBy(x => x));
            if (!anagrams.ContainsKey(sorted))
                anagrams.Add(sorted, new List<string> { str });
            else anagrams[sorted].Add(str);
        }

        return anagrams.Values.ToList();
    }
}
