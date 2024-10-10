
/**
 * Counts the number of nodes in a complete binary tree.
 *
 * This function calculates the number of nodes in a complete binary tree using the properties of the tree's height.
 * It recursively determines the height of the left and right subtrees to decide whether to traverse the left or right subtree next.
 *
 * @param root - The root node of the binary tree.
 * @returns The total number of nodes in the binary tree.
 */
function countNodes(root: TreeNode | null): number {
    if (root === null) return 0;

    let leftHeight = getHeight(root.left);
    let rightHeight = getHeight(root.right);

    if (leftHeight === rightHeight) {
        return (1 << leftHeight) + countNodes(root.right);
    } else {
        return (1 << rightHeight) + countNodes(root.left);
    }
}

function getHeight(node: TreeNode | null): number {
    let height = 0;
    while (node !== null) {
        height++;
        node = node.left;
    }
    return height;
}
// Example usage:
class TreeNode {
    val: number;
    left: TreeNode | null;
    right: TreeNode | null;
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = val === undefined ? 0 : val;
        this.left = left === undefined ? null : left;
        this.right = right === undefined ? null : right;
    }
}

const root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));
console.log(countNodes(root)); // Output: 5
 //add alternative solution
 function countNodes(root: TreeNode | null): number {
    if (root === null) return 0;

    let leftHeight = getHeight(root.left);
    let rightHeight = getHeight(root.right);

    if (leftHeight === rightHeight) {
        return (1 << leftHeight) + countNodes(root.right);
    } else {
        return (1 << rightHeight) + countNodes(root.left);
    }  
}