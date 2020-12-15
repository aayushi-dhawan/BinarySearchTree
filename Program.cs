using System;

namespace BSTTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Node Values");
            string numList = Console.ReadLine();
            Console.WriteLine(numList);
            string[] numListArr = numList.Split(',');
            Console.WriteLine(numListArr.Length);
            BST objBinaryTree = new BST();
            for(int i =0; i <numListArr.Length; i++ )
            { 
                Console.WriteLine(numListArr[i]);
                objBinaryTree.InsertNode(Int32.Parse(numListArr[i]));            
            }
            Console.WriteLine("InOrder Traversal");
            objBinaryTree.InOrdertraversal(objBinaryTree.Root);
            Console.WriteLine("PreOrder Traversal");
            objBinaryTree.PreOrdertraversal(objBinaryTree.Root);
            Console.WriteLine("PostOrder Traversal");
            objBinaryTree.PostOrdertraversal(objBinaryTree.Root);

            Console.Read();
        }
    }
}
