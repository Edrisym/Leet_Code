using _104_Maximum_Depth_of_Binary_Tree;
using LeetCode_Models;

var root = new TreeNode(3,
    left: new TreeNode(9),
    right: new TreeNode(20, right: new TreeNode(15), left: new TreeNode(7)));

var maxDepth = Solution.MaxDepth(root);
Console.WriteLine(maxDepth);

namespace _104_Maximum_Depth_of_Binary_Tree
{
    public static class Solution
    {
        public static int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;

            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            return 1 + Math.Max(leftDepth, rightDepth);
        }
    }
}

//Input: root = [3,9,20,null,null,15,7]
// Output: 3
// Example 2:
// 
// Input: root = [1,null,2]
// Output: 2

//Constraints:
// 
// The number of nodes in the tree is in the range [0, 104].
// -100 <= Node.val <= 100