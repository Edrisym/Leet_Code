using _872_Leaf_Similar_Trees;
using LeetCode_Models;

// root1 = [3,5,1,6,2,9,8,null,null,7,4]
var root1 = new TreeNode(3,
    new TreeNode(5,
        new TreeNode(6),
        new TreeNode(2,
            new TreeNode(7),
            new TreeNode(4)
        )
    ),
    new TreeNode(1,
        new TreeNode(9),
        new TreeNode(8)
    )
);

// root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
var root2 = new TreeNode(3,
    new TreeNode(5,
        new TreeNode(6),
        new TreeNode(7)
    ),
    new TreeNode(1,
        new TreeNode(4),
        new TreeNode(2,
            new TreeNode(9),
            new TreeNode(8)
        )
    )
);


new Solution().LeafSimilar(root1, root2);

namespace _872_Leaf_Similar_Trees
{
    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            return false;
        }
    }
}