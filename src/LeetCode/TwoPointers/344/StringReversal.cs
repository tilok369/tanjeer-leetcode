namespace LeetCode.TwoPointers._344;

public class StringReversal
{
    public static void Run()
    {
        Console.WriteLine("344. Reverse String: ");
        ReverseString(new[]{'H','e','l','l', 'o'});
        ReverseString(new[]{'H','a','n','n', 'a', 'h'});
    }
    
    private static void ReverseString(char[] s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
        
        Console.WriteLine(string.Join(", ", s));
    }
}