
namespace LeetCode.DFS;

// Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Tree
{
    public static IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        InOrder(list, root);
        return list;
    }

    private static void InOrder(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        InOrder(list, root.left);
        list.Add(root.val);
        InOrder(list, root.right);
    }

    public static IList<int> PreorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        PreOrder(list, root);
        return list;
    }

    private static void PreOrder(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        list.Add(root.val);
        PreOrder(list, root.left);
        PreOrder(list, root.right);
    }

    public static IList<int> PostorderTraversal(TreeNode root)
    {
        var list = new List<int>();

        PostOrder(list, root);
        return list;
    }

    private static void PostOrder(IList<int> list, TreeNode root)
    {
        if (root == null)
            return;

        PostOrder(list, root.left);
        PostOrder(list, root.right);
        list.Add(root.val);
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        if (p.val != q.val)
            return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null)
            return true;

        return IsSymmetricPart(root.left, root.right);
    }

    private static bool IsSymmetricPart(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p == null || q == null)
            return false;
        if (p.val != q.val)
            return false;

        return IsSymmetricPart(p.left, q.right)
            && IsSymmetricPart(p.right, q.left);
    }
}
