using System;
using NUnit.Framework;

[TestFixture]
public class SolutionTest {
    private Solution solution;

    [SetUp]
    public void SetUp() {
        solution = new Solution();
    }

    [Test]
    public void TestCountNodes_EmptyTree() {
        TreeNode root = null;
        int result = solution.CountNodes(root);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void TestCountNodes_SingleNode() {
        TreeNode root = new TreeNode(1);
        int result = solution.CountNodes(root);
        Assert.AreEqual(1, result);
    }

    [Test]
    public void TestCountNodes_CompleteTree() {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.right.left = new TreeNode(6);

        int result = solution.CountNodes(root);
        Assert.AreEqual(6, result);
    }

    [Test]
    public void TestCountNodes_IncompleteTree() {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        int result = solution.CountNodes(root);
        Assert.AreEqual(5, result);
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}