using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListEnqueue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null) 
                {
                    temp= temp.next;
                }
                temp.next = node; 
                
            }
            Console.WriteLine("{0} instered in to Queue", node.data);

        }

        internal void Display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while(temp!=null) 
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
