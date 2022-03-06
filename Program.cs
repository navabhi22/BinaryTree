using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BinarySearchTree");
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(56);
            binaryTree.Add(30);
            binaryTree.Add(70);

            binaryTree.TravarsePreorder(binaryTree.Root);

        }
    }
}