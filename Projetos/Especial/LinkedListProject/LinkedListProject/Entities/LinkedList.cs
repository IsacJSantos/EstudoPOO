using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject.Entities
{
    class LinkedList
    {
        private Node Head;

        public void Add(double value) 
        {
            Node node = new Node(value);
            node.SetNext(Head);
            Head = node;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");

            Node p = Head;
            while (p.GetNext() != null)
            {
                sb.Append(p.GetValue() + " ");
                p = p.GetNext();
            }

            sb.Append("]");

            return sb.ToString();
        }
    }
}
