using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListDequeue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} instered in to Queue", node.data);

        }

        internal void Dequeue(int data)
        {
            Node node = new Node(data);
            if(head==null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Node temp = this.head;
                this.head = this.head.next;
                if(this.head==null)
                {
                    this.head = null;
                }
                Console.WriteLine("Item deleted is{0}",temp.data);
            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

