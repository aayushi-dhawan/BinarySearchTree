using System;
namespace BSTTraversal
{
    public class Node
    {
          public int Data;  
          public Node Left;
          public Node Right;                              
    }

    public class BST
    {
        public Node Root;
        public BST()
        {
            Root = null;
        }

        public void InsertNode(int val)
        {
            Node current;
            Node parent;
            Node newNode = new Node();
            newNode.Data = val;
            if(this.Root == null)
            {
                this.Root = newNode;
                return;
            }
            else
            {
                current = this.Root;
                while(true)
                {
                    parent = current;
                    if(val <= current.Data)
                    {                       
                        current = current.Left;
                        if(current == null)
                        {                        
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if(current == null)
                        {                        
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        } 

        public void InOrdertraversal(Node Root)
        {
            if(Root != null)
            {
                InOrdertraversal(Root.Left);
                Console.WriteLine(Root.Data + " ");
                InOrdertraversal(Root.Right);
            }
        } 

        public void PreOrdertraversal(Node Root)
        {
            if(Root != null)
            {
                Console.WriteLine(Root.Data + " ");
                PreOrdertraversal(Root.Left);            
                PreOrdertraversal(Root.Right);
            }
        } 

        public void PostOrdertraversal(Node Root)
        { 
            if(Root != null)
            {          
                PostOrdertraversal(Root.Left);            
                PostOrdertraversal(Root.Right);
                Console.WriteLine(Root.Data + " ");
            }
        }  
    }    
}