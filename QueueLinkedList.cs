// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueLinkedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OopsPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Queue linked list class
    /// </summary>
    public class QueueLinkedList
    {
        /// <summary>
        /// The head
        /// </summary>
        private Node head;

        /// <summary>
        /// The tail
        /// </summary>
        private Node tail;

        /// <summary>
        /// The count variable
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueLinkedList"/> class.
        /// </summary>
        public QueueLinkedList()
        {
        }

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(object data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = this.head;
            }
            else
            {
                this.tail.Next = newNode;
                this.tail = this.tail.Next;
            }

            this.count++;
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <returns>returns the result</returns>
        /// <exception cref="Exception">Queue is Empty</exception>
        public object Dequeue()
        {
            if (this.head == null)
            {
                throw new Exception("Queue is Empty");
            }

            object result = this.head.Data;
            Console.WriteLine(result);
            this.head = this.head.Next;
            return result;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        /// <returns>returns str</returns>
        public object Print()
        {
            object str = " ";
            Node temp = this.head;
            while (temp.Equals(null))
            {
                str = str + " " + temp.Data;
                Console.WriteLine(str);
                temp = temp.Next;
            }

            return str;
        }

        /// <summary>
        /// Prints the data.
        /// </summary>
        public void PrintData()
        {
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get
            {
                return this.count;
            }
        }       
    }
}
