namespace _20250917
{
    class TreeNode<T>
    {
        public T Data;
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
    }
    class Program
    {
        static TreeNode<string> MakeTree()
        {
            TreeNode<string> root = new TreeNode<string>() { Data = "A" };
            {
                TreeNode<string> nodeB = new TreeNode<string>() { Data = "B" };
                {
                    TreeNode<string> nodeD = new TreeNode<string>() { Data = "D" };
                    {
                        TreeNode<string> nodeH = new TreeNode<string>() { Data = "H" };
                        TreeNode<string> nodeI = new TreeNode<string>() { Data = "I" };

                        nodeD.Children.Add(nodeH);
                        nodeD.Children.Add(nodeI);
                    }
                    TreeNode<string> nodeE = new TreeNode<string>() { Data = "E" };

                    nodeB.Children.Add(nodeD);
                    nodeB.Children.Add(nodeE);
                }
                TreeNode<string> nodeC = new TreeNode<string>() { Data = "C" };
                {
                    TreeNode<string> nodeF = new TreeNode<string>() { Data = "F" };
                    TreeNode<string> nodeG = new TreeNode<string>() { Data = "G" };

                    nodeC.Children.Add(nodeF);
                    nodeC.Children.Add(nodeG);
                }

                root.Children.Add(nodeB);
                root.Children.Add(nodeC);
            }

            return root;
        }

        static void PrintTree(TreeNode<string> node)
        {
            Console.WriteLine(node.Data);

            for (int i = 0; i < node.Children.Count; i++)
            {
                PrintTree(node.Children[i]);
            }
        }

        static void Main(string[] args)
        {
            var root = MakeTree();
            PrintTree(root);
        }
    }
}
