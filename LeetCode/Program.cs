using LeetCode.Problems.Easy;
using LeetCode.Problems.Medium;

No222_Count_Complete_Tree_Nodes Solution = new No222_Count_Complete_Tree_Nodes();

Console.WriteLine(Solution.CountNodes(new No222_Count_Complete_Tree_Nodes.TreeNode()
{
    val = 1,
    left = new No222_Count_Complete_Tree_Nodes.TreeNode() { val = 2 },
    right = new No222_Count_Complete_Tree_Nodes.TreeNode() { val = 3 }
}));