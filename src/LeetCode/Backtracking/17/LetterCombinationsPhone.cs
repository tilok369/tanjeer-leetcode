using System.Text;

namespace LeetCode.Backtracking._17;

public class LetterCombinationsPhone
{
    public static void Run()
    {
        Console.WriteLine("17. Letter Combinations of a Phone Number: ");
        Console.WriteLine(string.Join(",", LetterCombinationsPhone.LetterCombinations("23")));
        Console.WriteLine(string.Join(",", LetterCombinationsPhone.LetterCombinations("")));
        Console.WriteLine(string.Join(",", LetterCombinationsPhone.LetterCombinations("2")));
        Console.WriteLine(string.Join(",", LetterCombinationsPhone.LetterCombinations("234")));
    }

    private static Dictionary<char, List<char>> phonenumbers = new Dictionary<char, List<char>>
        {
            {'0', new List<char>()},
            {'1', new List<char>()},
            {'2', new List<char>() {'a', 'b', 'c'}},
            {'3', new List<char>() {'d', 'e', 'f'}},
            {'4', new List<char>() {'g', 'h', 'i'}},
            {'5', new List<char>() {'j', 'k', 'l'}},
            {'6', new List<char>() {'m', 'n', 'o'}},
            {'7', new List<char>() {'p', 'q', 'r', 's'}},
            {'8', new List<char>() {'t', 'u', 'v'}},
            {'9', new List<char>() {'w', 'x', 'y', 'z'}}
        };

    //private static List<string> combinations = new List<string>();

    public static IList<string> LetterCombinations(string digits)
    {
        var combinations = new List<string>();
        LetterCombinationConstructor(combinations, digits, 0, new StringBuilder());

        return combinations;
    }

    private static void LetterCombinationConstructor(List<string> combinations, string digits, int index, StringBuilder result)
    {
        if (index >= digits.Length)
        {
            if (result.Length > 0)
            {
                combinations.Add(result.ToString());
            }
            return;
        }

        var letters = phonenumbers[digits[index]];
        foreach (var letter in letters)
        {
            result.Append(letter);
            LetterCombinationConstructor(combinations, digits, index + 1, result);
            result.Remove(result.Length - 1, 1);
        }
    }
}
