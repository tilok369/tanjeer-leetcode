using LeetCode.DFS;

namespace LeetCode.Tree._144;

public class PreOrder
{
    public static void Run()
    {
        Console.WriteLine("144. Binary Tree Preorder Traversal: ");
        var tree1 = new TreeNode(1);
        tree1.left = new TreeNode(2);
        tree1.right = new TreeNode(3);
        tree1.left.left = new TreeNode(4);
        tree1.left.right = new TreeNode(5);
        Console.WriteLine(string.Join(",", PreOrder.PreorderTraversal(tree1)));

        var tree2 = new TreeNode(1);
        tree2.right = new TreeNode(2);
        tree2.right.left = new TreeNode(3);
        Console.WriteLine(string.Join(",", PreOrder.PreorderTraversal(tree2)));
    }

    public static IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        PreOrderT(list, root);
        return list;
    }

    private static void PreOrderT(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        list.Add(root.val);
        PreOrderT(list, root.left);
        PreOrderT(list, root.right);
    }
}
