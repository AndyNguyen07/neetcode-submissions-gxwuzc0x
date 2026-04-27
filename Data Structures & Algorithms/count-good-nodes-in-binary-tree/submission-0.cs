/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        return CountGoodNodes(root, int.MinValue);
    }
    private int CountGoodNodes(TreeNode node, int maxSoFar)
    {
        if (node == null)
        {
            return 0;
        }

        int count = 0;

        if (node.val >= maxSoFar)
        {
            count = 1;
        }

        int newMax = Math.Max(maxSoFar, node.val);

        int leftCount = CountGoodNodes(node.left, newMax);
        int rightCount = CountGoodNodes(node.right, newMax);

        return count + leftCount + rightCount;
    }
}
