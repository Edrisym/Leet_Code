using System.Text;

// For tree 'p'
TreeNode p = new TreeNode(1, new TreeNode(2));

// For tree 'q'
TreeNode q = new TreeNode(1, null, new TreeNode(2));


var s = Solution.IsSameTree(p, q);
Console.WriteLine(s);


public class Solution
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        var isSame = false;
        StringBuilder pNodes = new StringBuilder();
        StringBuilder qNodes = new StringBuilder();

        Console.WriteLine(pNodes);
        Console.WriteLine(qNodes);

        PreOrder(p, pNodes);
        PreOrder(q, qNodes);

        if (qNodes.Equals(pNodes))
        {
            isSame = true;
        }

        return isSame;
    }

    static void PreOrder(TreeNode node, StringBuilder nodes)
    {
        if (node == null){}

        nodes.Append(node.val);

        PreOrder(node.left, nodes);
        PreOrder(node.right, nodes);
    }
}