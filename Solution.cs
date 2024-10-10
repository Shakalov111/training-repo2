public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;

        int height = GetHeight(root);
        if (height == 0) return 1;

        int upperCount = (1 << height) - 1;
        int left = 0, right = upperCount;

        while (left < right) {
            int idxToFind = (int)Math.Ceiling((left + right) / 2.0);
            if (NodeExists(idxToFind, height, root)) {
                left = idxToFind;
            } else {
                right = idxToFind - 1;
            }
        }

        return upperCount + left + 1;
    }

    private int GetHeight(TreeNode node) {
        int height = 0;
        while (node.left != null) {
            height++;
            node = node.left;
        }
        return height;
    }

    private bool NodeExists(int idxToFind, int height, TreeNode node) {
        int left = 0, right = (1 << height) - 1;
        int count = 0;
        while (count < height) {
            int midOfNode = (left + right) / 2;
            if (idxToFind <= midOfNode) {
                node = node.left;
                right = midOfNode;
            } else {
                node = node.right;
                left = midOfNode + 1;
            }
            count++;
        }
        return node != null;
    }
}