using _872_Leaf_Similar_Trees;
using LeetCode_Models;

//https://leetcode.com/problems/leaf-similar-trees/?envType=study-plan-v2&envId=leetcode-75

// root1 = [3,5,1,6,2,9,8,null,null,7,4]
// var root1 = new TreeNode(3,
//     new TreeNode(5,
//         new TreeNode(6),
//         new TreeNode(2,
//             new TreeNode(7),
//             new TreeNode(4)
//         )
//     ),
//     new TreeNode(1,
//         new TreeNode(9),
//         new TreeNode(8)
//     )
// );
//
// // root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
// var root2 = new TreeNode(3,
//     new TreeNode(5,
//         new TreeNode(6),
//         new TreeNode(7)
//     ),
//     new TreeNode(1,
//         new TreeNode(4),
//         new TreeNode(2,
//             new TreeNode(9),
//             new TreeNode(8)
//         )
//     )
// );


var root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
var root2 = new TreeNode(1, new TreeNode(3), new TreeNode(2));

Console.WriteLine(new Solution().LeafSimilar(root1, root2));

namespace _872_Leaf_Similar_Trees
{
    public class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var e1 = GetLeaves(root1).GetEnumerator();
            var e2 = GetLeaves(root2).GetEnumerator();

            while (true)
            {
                var has1 = e1.MoveNext();
                var has2 = e2.MoveNext();

                if (has1 != has2)
                    return false;

                if (!has1)
                    return true;

                if (e1.Current != e2.Current)
                    return false;
            }
        }

        private IEnumerable<int> GetLeaves(TreeNode root)
        {
            if (root == null) yield break;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.left == null && node.right == null)
                {
                    yield return node.val;
                }
                else
                {
                    if (node.right != null) stack.Push(node.right);
                    if (node.left != null) stack.Push(node.left);
                }
            }
        }
    }
}

// public class Solution
// {
//     public bool LeafSimilar(TreeNode root1, TreeNode root2)
//         => GetLeaves(root1).SequenceEqual(GetLeaves(root2));
//
//     private IEnumerable<int> GetLeaves(TreeNode node)
//     {
//         if (node == null)
//             yield break;
//
//         if (node.left == null && node.right == null)
//         {
//             yield return node.val;
//         }
//         else
//         {
//             foreach (var val in GetLeaves(node.left))
//                 yield return val;
//             foreach (var val in GetLeaves(node.right))
//                 yield return val;
//         }
//     }


//public class Solution
// {
//     public bool LeafSimilar(TreeNode root1, TreeNode root2)
//     {
//         var e1 = GetLeaves(root1).GetEnumerator();
//         var e2 = GetLeaves(root2).GetEnumerator();
// 
//         while (true)
//         {
//             var has1 = e1.MoveNext();
//             var has2 = e2.MoveNext();
// 
//             if (has1 != has2)
//                 return false; // different number of leaves
// 
//             if (!has1) // both finished
//                 return true;
// 
//             if (e1.Current != e2.Current)
//                 return false; // mismatch
//         }
//     }
// 
//     private IEnumerable<int> GetLeaves(TreeNode root)
//     {
//         if (root == null) yield break;
// 
//         var stack = new Stack<TreeNode>();
//         stack.Push(root);
// 
//         while (stack.Count > 0)
//         {
//             var node = stack.Pop();
//             if (node.left == null && node.right == null)
//             {
//                 yield return node.val;
//             }
//             else
//             {
//                 // push right first to process left first
//                 if (node.right != null) stack.Push(node.right);
//                 if (node.left != null) stack.Push(node.left);
//             }
//         }
//     }
// }
//  