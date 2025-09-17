

namespace BST_BinarySearchTree
{
    class BSTNode
    {
        public int Key;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int key)
        {
            this.Key = key;
        }
    }

    class BinarySearchTree
    {
        private BSTNode _root;
        public void Insert(int key)
        {
            _root = InsertRec(_root, key);
        }

        private BSTNode InsertRec(BSTNode node, int key)
        {
            if (node == null)
                return new BSTNode(key);

            if (node.Key > key)
                node.Left = InsertRec(node.Left, key);

            else
                node.Right = InsertRec(node.Right, key);

            return node;
        }

        public bool Contains(int key)
        {
            BSTNode node = _root;

            while (node != null)
            {
                if (node.Key == key) return true;
                else
                {
                    if (node.Key > key) node = node.Left;
                    else node = node.Right;
                }
            }

            return false;
        }

        public void Remove(int key)
        {
            _root = RemoveRec(_root, key);
        }

        private BSTNode RemoveRec(BSTNode node, int key)
        {
            if (node == null)
            {
                return null;
            }

            else
            {
                if (node.Key > key) node.Left = RemoveRec(node.Left, key);
                else if (node.Key < key) node.Right = RemoveRec(node.Right, key);
                else
                {
                    if (node.Left != null && node.Right != null) 
                    { 
                        FindMin(node.Right).Left = node.Left;
                        node = FindMin(node.Right); 
                    }
                    else if (node.Right != null)
                        node = node.Right;

                    else if (node.Left != null) 
                        node = node.Left;

                    else return null;
                }
            }

            return node;
        }

        private BSTNode FindMin(BSTNode node)
        {
            if (node.Left != null) FindMin(node.Left);

            return node;
        }
    }

    class BST
    {
        static void Main()
        {
            var bsT = new BinarySearchTree();
            int[] data = { 16, 14, 78, 31, 28 , 87, 90 };
            foreach(int i in data)
            {
                bsT.Insert(i);
            }

            bsT.Remove(78);

            Console.WriteLine( bsT.Contains(87) );

        }
    }
}
