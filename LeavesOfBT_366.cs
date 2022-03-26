using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.leet
{
    public class LeavesOfBT_366
    {
        static void Main2(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode two = new TreeNode(2);
            TreeNode three = new TreeNode(3);
            TreeNode four = new TreeNode(4);
            TreeNode five = new TreeNode(5);

            root.left = two;
            root.right= three;
            two.left = four;
            two.right = five;

            List<List<int>> result = new LeavesOfBT_366().FindLeaves(root);
        }

        List<List<int>> result = new List<List<int>>();
        List<List<int>> FindLeaves(TreeNode root)
        {
            if(root == null)
            {
                return result;
            }
            Dfs(root);
            return result;
        }

        int Dfs (TreeNode root)
        {
            if(root == null)
            {
                return -1;
            }
            int left = Dfs(root.left);
            int right = Dfs(root.right);

            int level = Math.Max(left, right)+1;

            if(result.Count <= level)
            {
                List<int> list = new List<int>();
                result.Add(list);
            }
            result.ElementAt(level).Add(root.val);
            return level;
        }

        class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
