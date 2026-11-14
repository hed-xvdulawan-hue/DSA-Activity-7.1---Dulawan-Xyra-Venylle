// DSA Activity 7.1 - Dulawan, Xyra Venylle
using System;
using System.Collections.Generic;

namespace DSAActivity7_1
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node tree1 = new Node(12,
                new Node(90,
                    new Node(-50),
                    new Node(100, new Node(46), null)),
                new Node(-32,
                    null,
                    new Node(21,
                        new Node(68, new Node(9), new Node(11)),
                        new Node(12, null, new Node(-6)))));
            Node tree2 = new Node(1,
                new Node(2,
                    new Node(4,
                        new Node(8),
                        new Node(9, new Node(12), new Node(13))),
                    new Node(5, null, new Node(10))),
                new Node(3,
                    new Node(6),
                    new Node(7, new Node(11, new Node(14), null), null)));
            Node tree3 = new Node(15,
                new Node(11,
                    new Node(8, new Node(6), new Node(9)),
                    new Node(12, null, new Node(14))),
                new Node(26,
                    new Node(20),
                    new Node(30, null, new Node(35))));
            Node tree4 = new Node(7,
                new Node(3,
                    new Node(1, new Node(0), new Node(2)),
                    new Node(6, new Node(4, null, new Node(5)), null)),
                new Node(12,
                    new Node(9,
                        new Node(8),
                        new Node(11, new Node(10), null)),
                    new Node(13, null, new Node(15, new Node(14), null))));

            ShowTraversals(1, tree1);
            ShowTraversals(2, tree2);
            ShowTraversals(3, tree3);
            ShowTraversals(4, tree4);
        }

        static void ShowTraversals(int item, Node root)
        {
            Console.WriteLine("Item " + item);

            List<int> result = new List<int>();
            PreOrder(root, result);
            Console.WriteLine("Pre-Order  : " + string.Join(" ", result));

            result = new List<int>();
            InOrder(root, result);
            Console.WriteLine("In-Order   : " + string.Join(" ", result));

            result = new List<int>();
            PostOrder(root, result);
            Console.WriteLine("Post-Order : " + string.Join(" ", result));

            Console.WriteLine();
        }
        static void PreOrder(Node node, List<int> result)
        {
            if (node == null)
                return;

            result.Add(node.Value);
            PreOrder(node.Left, result);
            PreOrder(node.Right, result);
        }
        static void InOrder(Node node, List<int> result)
        {
            if (node == null)
                return;

            InOrder(node.Left, result);
            result.Add(node.Value);
            InOrder(node.Right, result);
        }

        static void PostOrder(Node node, List<int> result)
        {
            if (node == null)
                return;

            PostOrder(node.Left, result);
            PostOrder(node.Right, result);
            result.Add(node.Value);
        }
    }
}