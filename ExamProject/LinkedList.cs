using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    
    class LinkedList<T> : ILinkedList<T>
    {
        Node<T> node = null;
        int size = 0;

        public void AddFirst(T value)  // add node to the first place;
        {
            size++;
            if (node == null)
            {
                node = new Node<T>(null, value, null);              
            }
            else
            {
                Node<T> temp = new Node<T>(null, value, First());
                First().prevNode = temp;                
            }
        }
        
        public void AddLast(T value)  // add node to the last place;
        {
            size++;
            if (node == null)
            {
                node = new Node<T>(null, value, null);
            }
            else
            {
                Node<T> temp = new Node<T>(Last(), value, null);
                Last().nextNode = temp;
                                    
            }
        }

        public void Remove(T value) // remove specific node;
        {
            node = First();
            if (node == null)
            {
                Console.WriteLine("The list is empty! Nothing to remove!");                
            }
            else
            {
                while (true)
                {
                    if (node.nodeData.Equals(value))
                    {
                        if(node.prevNode == null)
                        {
                            RemoveFirst();                            
                        }
                        else if(node.nextNode == null)
                        {
                            RemoveLast();
                        }
                        else
                        {
                            Node<T> temp = node.nextNode;
                            node.nextNode.prevNode = node.prevNode;
                            node.prevNode.nextNode = node.nextNode;
                            node.prevNode.nextNode = temp;                                                                                
                            size--;                           
                            break;
                        }                        
                    }
                    else if (node.nextNode == null)
                    {
                        break;
                    }
                    else
                    {
                        node = node.nextNode;
                    }
                }
            }            
        }
        public void RemoveFirst() // remove first node;
        {
             while(true)
              {
                 if(node == null)
                 {
                     break;
                 }
                 else if(node.prevNode == null && node.nextNode == null)
                 {                     
                     size--;                    
                     Print();
                     return;
                 }
                 else if (node.prevNode == null)
                 {
                     node.nextNode.prevNode = null;
                     node = node.nextNode;
                     size--;
                    break;
                 }                   
                 else
                 {
                     node = node.prevNode;
                 }                 
              }
        }
        public void RemoveLast()  // remove last node;
        {
            while (true)
            {
                if (node == null)
                {
                    break;
                }
                else if (node.prevNode == null && node.nextNode == null)
                {
                    size--;
                    Print();
                    return;
                }
                else if (node.nextNode == null)
                {
                    node.prevNode.nextNode = null;
                    node = node.prevNode;
                    size--;
                    break;
                }
                else
                {
                    node = node.nextNode;
                }
            }
        }
       
        public bool Find(T value)  // find value in node;
        {
            node = Last();            
            if (node == null)
            {               
                return false;
            }
            else
            {
                while(true)
                {
                    if(node.nodeData.Equals(value))
                    {
                        return true;
                    }    
                    else if (node.prevNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        node = node.prevNode;
                    }                   
                }                
            }            
        }
        
        public int Length()  // define LinkedList length;
        {
            return size;
        }

       public Node<T> First() // display first node in the list;
        {
            while (true)
            {
                if (node == null)
                {
                    return null;
                }
                else if (node.prevNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.prevNode;
                }
            }
        }

       public Node<T> Last() // display last node in the list;
        {
            while (true)
            {
                if(node == null)
                {
                    return null;
                }
                else if (node.nextNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.nextNode;
                }
            }
        }

        public void Print() // print list length and each node value;
        {
            Console.WriteLine("Total number of values in list: {0}", Length());
                      
            if (First() == null)
            {
                return;
            }            
            else
            {
                Node<T> temp = node;  // define temporal variable to avoid changes in nodes;
                for (int i = 1; i <= Length(); i++)
                {
                   Console.Write("Value " + i + " in list: {0}\n", temp.nodeData);
                   temp = temp.nextNode;             
                }
            }         
        }
    }
}
