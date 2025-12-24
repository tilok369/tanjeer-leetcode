using System.Text;

namespace LeetCode.Stack._71;

public class PathSimplification
{
    public static void Run()
    {
        Console.WriteLine("71. Simplify Path");
        Console.WriteLine(SimplifyPath("/home/"));
        Console.WriteLine(SimplifyPath("/home//foo/"));
        Console.WriteLine(SimplifyPath("/home/user/Documents/../Pictures"));
        Console.WriteLine(SimplifyPath("/../"));
        Console.WriteLine(SimplifyPath("/.../a/../b/c/../d/./"));
    }
    
    
    private static string SimplifyPath(string path) 
    {
        var parts = path.Split('/');
        var stack = new Stack<string>();
        foreach (var part in parts)
        {
            if(string.IsNullOrEmpty(part) || part == ".") 
                continue;
            if (part == "..")
            {
                if(stack.Count > 0)
                    stack.Pop();
            }
            else
            {
                stack.Push(part);
            }
        }

        if (stack.Count == 0)
            return "/";

        var simplifiedPath = new StringBuilder();
        while (stack.Count > 0)
        {
            simplifiedPath.Insert(0, "/" + stack.Pop());
        }
        
        return simplifiedPath.ToString();
    }
}