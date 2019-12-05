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
        var sum = 0;

        if(root.val >= L && root.val <= R){
            sum += root.val;
        }

        if(root.left != null){
            sum += RangeSumBST(root.left, L,R);
        }

         if(root.right != null){
            sum += RangeSumBST(root.right, L,R);
        }

        return sum;
    }
}
