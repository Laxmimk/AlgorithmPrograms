// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DNode.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class for node
    /// </summary>
    public class DNode
    {
        /// <summary>
        /// The data in node
        /// </summary>
        private object data;

        /// <summary>
        /// The next node
        /// </summary>
        private DNode next;

        /// <summary>
        /// The previous node
        /// </summary>
        private DNode prev;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="o">The object</param>
        /// <param name="n">The next node</param>
        /// <param name="p">The previous node</param>
        public DNode(object o, DNode n, DNode p)
        {
            this.data = o;
            this.next = n;
            this.prev = p;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>the object </returns>
        public object GetData()
        {
            return this.data;
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="o">The object</param>
        public void SetData(object o)
        {
            this.data = o;
        }

        /// <summary>
        /// Sets the next nodes value.
        /// </summary>
        /// <param name="n">The n.</param>
        public void SetNext(DNode n)
        {
            this.next = n;
        }

        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns>the address in next node</returns>
        public DNode GetNext()
        {
            return this.next;
        }

        /// <summary>
        /// Sets the previous node.
        /// </summary>
        /// <param name="n">The node</param>
        public void SetPrev(DNode n)
        {
            this.prev = n;
        }

        /// <summary>
        /// Gets the previous.
        /// </summary>
        /// <returns>the previous node</returns>
        public DNode GetPrev()
        {
            return this.prev;
        }
    }
}
