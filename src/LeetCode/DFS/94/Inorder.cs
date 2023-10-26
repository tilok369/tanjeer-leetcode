using LeetCode.DFS;

namespace LeetCode.Tree._94;

public class Inorder
{
    public static void Run()
    {
        Console.WriteLine("94. Binary Tree Inorder Traversal: ");
        var tree1 = new TreeNode(1);
        tree1.left = new TreeNode(2);
        tree1.right = new TreeNode(3);
        tree1.left.left = new TreeNode(4);
        tree1.left.right = new TreeNode(5);
        Console.WriteLine(string.Join(",", Inorder.InorderTraversal(tree1)));

        var tree2 = new TreeNode(1);
        tree2.right = new TreeNode(2);
        tree2.right.left = new TreeNode(3);
        Console.WriteLine(string.Join(",", Inorder.InorderTraversal(tree2)));
    }

    public static IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        InOrderT(list, root);
        return list;
    }

    private static void InOrderT(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        InOrderT(list, root.left);
        list.Add(root.val);
        InOrderT(list, root.right);
    }
}
