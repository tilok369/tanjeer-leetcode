using LeetCode.DFS;

namespace LeetCode.Tree._145;

public class Postorder
{
    public static void Run()
    {
        Console.WriteLine("145. Binary Tree Traversal: ");
        var tree1 = new TreeNode(1);
        tree1.left = new TreeNode(2);
        tree1.right = new TreeNode(3);
        tree1.left.left = new TreeNode(4);
        tree1.left.right = new TreeNode(5);
        Console.WriteLine(string.Join(",", Postorder.PostorderTraversal(tree1)));

        var tree2 = new TreeNode(1);
        tree2.right = new TreeNode(2);
        tree2.right.left = new TreeNode(3);
        Console.WriteLine(string.Join(",", Postorder.PostorderTraversal(tree2)));
    }

    public static IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        PostOrderT(list, root);
        return list;
    }

    private static void PostOrderT(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        PostOrderT(list, root.left);
        PostOrderT(list, root.right);
        list.Add(root.val);
    }
}
