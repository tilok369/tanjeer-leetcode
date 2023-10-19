namespace LeetCode.TwoPointers._696;

public class CountBinarySubstrings
{
    public static void Run() 
    {
        Console.WriteLine("696. Count Binary Substrings: ");
        Console.WriteLine(CountBinarySubstrings.CountSubstring("010011"));
        Console.WriteLine(CountBinarySubstrings.CountSubstring("0001110010"));
    }

    public static int CountSubstring(string s)
    {
        // To store the total count
        // of substrings
        int ans = 0;

        int i = 0;

        var n = s.Length;

        // Traversing the string
        while (i < n)
        {

            // Count of consecutive
            // 0's & 1's
            int cnt0 = 0, cnt1 = 0;

            // Counting subarrays of
            // type "01"
            if (s[i] == '0')
            {

                // Count the consecutive
                // 0's
                while (i < n && s[i] == '0')
                {
                    cnt0++;
                    i++;
                }

                // If consecutive 0's
                // ends then check for
                // consecutive 1's
                int j = i;

                // Counting consecutive 1's
                while (j < n && s[j] == '1')
                {
                    cnt1++;
                    j++;
                }
            }

            // Counting subarrays of
            // type "10"
            else
            {

                // Count consecutive 1's
                while (i < n && s[i] == '1')
                {
                    cnt1++;
                    i++;
                }

                // If consecutive 1's
                // ends then check for
                // consecutive 0's
                int j = i;

                // Count consecutive 0's
                while (j < n && s[j] == '0')
                {
                    cnt0++;
                    j++;
                }
            }

            // Update the total count
            // of substrings with
            // minimum of (cnt0, cnt1)
            ans += Math.Min(cnt0, cnt1);
        }

        // Return answer
        return ans;
    }
}
