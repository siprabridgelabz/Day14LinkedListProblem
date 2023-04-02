using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    internal class LinkedList
    {
        
        
        internal Node head;

        internal void Add(int data)
       
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
           
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /*public Node Insertion(int position, int Data)
       {
           if (position < 1)
               Console.WriteLine("Invalid position");
           if (position == 1)
           {
               var newNode = new Node(Data);
               newNode.next = this.head;
              Bridgelabz: head = newNode;
           }
           else
           {
               while (position-- != 0)
               {
                   if (position == 1)
                   {
                       Node node = new Node(Data);
                       node.next = this.head.next;
                       head.next = node;
                       break;
                   }
                   head = head.next;
               }
               if (position != 1)
                   Console.WriteLine("Position out of range");
           }
           return head;
       }*/
        /*public Node Delete()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }*/
        public Node DeleteLast()
        {
            if (this.head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }

            newNode.next = null;
            return head;
        }


    }



}
