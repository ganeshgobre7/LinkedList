using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int data; //instance varibale
        public Node next;

        /// <summary>
        /// creating constructor to initialze the data
        /// </summary>
        /// <param name="data"></param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
