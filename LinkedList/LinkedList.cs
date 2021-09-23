using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Method to Adding Elements in LL
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data); //creating object to getting new node
            if (this.head == null) //if list is empty
            {
                this.head = node;
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
            Console.WriteLine("Insered Element in Linked list is :" + node.data);
        }
        /// <summary>
        /// Method to Adding Element at First Position in LL
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtFirst(int data)
        {
            Node node = new Node(data); //creating object to getting new node
            if (this.head == null) //if list is empty
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("After inserting Node at first Position :" + data);
        }
        /// <summary>
        /// Method for Adding Element in Last Position in LL
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtLast(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("After inserting at last position : " + data);
        }
        /// <summary>
        /// Method to Adding Elment between two Element
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertAtMiddle(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("After inserting at middle between 56 & 70 : " + data);
        }
        /// <summary>
        /// Method to Deleting First Element in LL
        /// </summary>
        public void DeleteFirst()
        {
            if (this.head ==null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("After deleting First node :");
        }

        /// <summary>
        /// Method to Delete the Last Element
        /// </summary>
        public void DeleteLast()
        {
            Node temp =head;
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                while (temp.next.next!= null) 
                {
                    temp = temp.next;                   
                }
                temp.next = null;
                Console.WriteLine("After deleting Last node :");
            }
        }
        
        /// <summary>
        /// Method to Display the Element in LL
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
