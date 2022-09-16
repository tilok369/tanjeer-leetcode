
namespace LeetCode;

public class FizzBuzz
{
    public static IList<string> FizzBuzzs(int n)
    {
        var fizzBuzzs = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
                fizzBuzzs.Add("FizzBuzz");
            else if (i % 3 == 0)
                fizzBuzzs.Add("Fizz");
            else if (i % 5 == 0)
                fizzBuzzs.Add("Buzz");
            else
                fizzBuzzs.Add(i.ToString());
        }

        return fizzBuzzs;
    }
}
