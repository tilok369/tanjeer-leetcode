namespace LeetCode.HashTables._242;

public class ValidAnagram
{
    public static void Run()
    {
        Console.WriteLine("242. Valid Anagram: ");
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }

    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        var letters = new Dictionary<char, int>();
        foreach (var letter in s) 
        { 
            if(letters.ContainsKey(letter))
                letters[letter]++;
            else
                letters.Add(letter, 1);
        }

        foreach (var letter in t)
        {
            if(!letters.ContainsKey(letter))
                return false;
            letters[letter]--;
            if (letters[letter] < 0)
                return false;
        }

        return true;
    }
}
