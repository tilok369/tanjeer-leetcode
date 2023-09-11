namespace LeetCode.Strings._412;

public class FizzBuzzs
{
    public static void Run()
    {
        Console.WriteLine("Fizz Buzz:");
        Console.WriteLine(String.Join(", ", FizzBuzzs.FizzBuzz(3)));
        Console.WriteLine(String.Join(", ", FizzBuzzs.FizzBuzz(5)));
        Console.WriteLine(String.Join(", ", FizzBuzzs.FizzBuzz(15)));
    }

    public static IList<string> FizzBuzz(int n)
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
