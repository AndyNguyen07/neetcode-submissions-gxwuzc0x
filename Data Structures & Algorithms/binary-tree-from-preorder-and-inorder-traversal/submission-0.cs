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
    private int preorderIdx = 0;
        private Dictionary<int,int> inorderMap = new Dictionary<int,int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        return Build(preorder, 0, inorder.Length - 1);
    }
    // build tree based on inorder [left,right]
    private TreeNode Build(int[] preorder, int left, int right)
    {
        // base case
        if (left > right)
        {
            return null;
        }

        int rootValue = preorder[preorderIdx];
        preorderIdx ++;

        TreeNode root = new TreeNode(rootValue);

        int rootIdx = inorderMap[rootValue];

        root.left = Build(preorder, left, rootIdx - 1);
        root.right = Build(preorder, rootIdx + 1, right);

        return root;
    }
}
