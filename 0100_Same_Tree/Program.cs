using System.Text;

// For tree 'p'
TreeNode p = new TreeNode(1, new TreeNode(2));

// For tree 'q'
TreeNode q = new TreeNode(1, null, new TreeNode(2));


var s = Solution.IsSameTree(p, q);
Console.WriteLine(s);

public static class Solution
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        StringBuilder pNodes = new StringBuilder();
        StringBuilder qNodes = new StringBuilder();

        PreOrder(p, pNodes);
        PreOrder(q, qNodes);
        
        return pNodes.ToString().Equals(qNodes.ToString());
    }

    static void PreOrder(TreeNode node, StringBuilder nodes)
    {
        if (node == null)
        {
            nodes.Append("#,");
            return;
        }

        nodes.Append(node.val + ",");
        PreOrder(node.left, nodes); 
        PreOrder(node.right, nodes);
    }
}