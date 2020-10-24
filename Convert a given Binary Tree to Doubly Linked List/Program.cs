using System;
using System.Net.Http.Headers;

namespace Convert_a_given_Binary_Tree_to_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(10);
            root.left = new Node(12);
            root.left.left = new Node(25);
            root.left.right = new Node(30);
            root.right = new Node(15);
            root.right.left = new Node(36);
            ConvertBSTToDLL(root);
            Print(head);
        }

        public class Node
        {
            public int val { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

            public Node(int val = 0)
            {
                this.val = val;
                left = right = null;
            }
        }

        static Node head;
        static Node prev;
        static void ConvertBSTToDLL(Node root)
        {
            if (root == null) return;

            ConvertBSTToDLL(root.left);
            if(head == null)
            {
                head = root;
            }
            else
            {
                root.left = prev;
                prev.right = root;
            }
            prev = root;
            ConvertBSTToDLL(root.right);
        }
        static void Print(Node root)
        {
            while (root != null)
            {
                Console.WriteLine(root.val);
                root = root.right;
            }
        }
    }
}
