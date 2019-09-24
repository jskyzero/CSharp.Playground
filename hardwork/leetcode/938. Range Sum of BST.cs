/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int RangeSumBST(TreeNode root, int L, int R) {
        if (root == null) return 0;

        int after = RangeSumBST(root.left, L, R) +
                    RangeSumBST(root.right, L, R);
        return (root.val >= L &&
            root.val <= R) ? root.val + after : after;
    }
}