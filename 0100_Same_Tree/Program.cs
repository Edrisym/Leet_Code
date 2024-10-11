// For tree 'p'

using System.Runtime.CompilerServices;

TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));

// For tree 'q'
TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));


Solution.IsSameTree(p, q);


public class Solution
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        var isSame = false;
        List<int> nodes = new List<int>();

        PreOrder(p, nodes);
        PreOrder(p, nodes);

        return isSame;
    }

    static void PreOrder(TreeNode node, List<int> nodes)
    {
        if (node == null) return;

        nodes.Add(node.val);
        PreOrder(node.left, nodes);
        PreOrder(node.right, nodes);
    }
}